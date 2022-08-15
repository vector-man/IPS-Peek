//using IpsPeek.IO;

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO.Abstractions;
using System.Reactive;
using IpsPeek.Lib.IO.Patching;
using IpsPeek.UI.Services;
using ReactiveUI;

namespace IpsPeek.UI.ViewModels
{
    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        private readonly IFileSystem _fileSystem;
        private readonly IOpenFileDialogService _openFileDialogService;

        private Stream _dataStream;
        private string _filePath;
        private byte[] _patchData;
        private readonly FileOpenOptions _browseFileOptions = new FileOpenOptions();
        private bool _closeRequested;
        private ReactiveCommand<Unit, Unit> _requestClose;
        private readonly RoutingState _router;
        private readonly ViewModelActivator _activator = new ViewModelActivator();
        private ReactiveCommand<Unit, Unit> _closeFile;
        private ReactiveCommand<Unit, Unit> _closePatch;
        private ReactiveCommand<Unit, Unit> _closeTable;
        private ReactiveCommand<Unit, Unit> _copyDisabledPatchRecords;
        private ReactiveCommand<Unit, Unit> _copyEnablesPatchRecords;
        private ReactiveCommand<Unit, Unit> _copySelectedFileDataAsHex;
        private ReactiveCommand<Unit, Unit> _copySelectedFileDataAsString;
        private ReactiveCommand<Unit, Unit> _copySelectedPatchRecords;
        private ReactiveCommand<Unit, Unit> _exportSelectedPatchRecordListAsText;
        private int[] _fileName;
        private ReactiveCommand<Unit, Unit> _findNextFileDataCommand;
        private ReactiveCommand<Unit, Unit> _findPreviousFileDataCommand;
        private bool _hexViewVisible;
        private ReactiveCommand<Unit, Unit> _hideHexViewCommand;
        private ReactiveCommand<Unit, Unit> _hideStringViewCommand;
        private ReactiveCommand<Unit, Unit> _browseFileCommand;
        private ReactiveCommand<Unit, Unit> _browsePatchCommand;
        private ReactiveCommand<Unit, Unit> _browseTableCommand;
        private string _patchName;
        private ReadOnlyCollection<BinaryElementRecord<IpsValueElement>> _patchRecords;
        private ReactiveCommand<Unit, Unit> _selectAllData;
        private byte[] _selectedData;
        private int _selectedPatchRecordRow;
        private ReactiveCommand<Unit, Unit> _showFileDataHexView;
        private ReactiveCommand<Unit, Unit> _showGoToDataOffset;
        private ReactiveCommand<Unit, Unit> _showHexView;
        private ReactiveCommand<Unit, Unit> _showHorizontalLayout;
        private ReactiveCommand<Unit, Unit> _showLanguageView;
        private ReactiveCommand<Unit, Unit> _showSettings;
        private ReactiveCommand<Unit, Unit> _showStringHexView;
        private ReactiveCommand<Unit, Unit> _showToolbar;
        private ReactiveCommand<Unit, Unit> _showVerticalLayout;
        private bool _stringViewVisible;
        private int[] _tableName;
        private int[] _tablePath;
        private int _fileSize;
        private int _patchCount;
        private int _selectedPatchCount;
        private bool _visible;
        private bool _isVerticalLayout;
        private readonly IpsPatchScanner _scanner;
        private ReadOnlyCollection<BinaryElementRecord<IValueElement>> _patchRecords1;
        private ReadOnlyCollection<BinaryElementRecord<IpsValueElement>> _patchRecords2;

        public MainViewModel()
        {
        }

        public MainViewModel(IOpenFileDialogService openFileDialogService,
            IFileSystem fileSystem,
            IpsPatchScanner scanner)
        {
            _openFileDialogService = openFileDialogService;
            _fileSystem = fileSystem;
            _scanner = scanner;

            this.WhenActivated(d =>
            {
                // ReactiveCommand creation:
                d(RequestClose = ReactiveCommand.Create(() => { CloseRequested = true; },
                    this.WhenAnyValue(x => x.CloseRequested, x => !x), RxApp.MainThreadScheduler));

                d(BrowseFileCommand = ReactiveCommand.Create(BrowseFile));
                d(BrowsePatchCommand = ReactiveCommand.Create(BrowsePatch));
            });
        }

        private void BrowsePatch()
        {
            if (_openFileDialogService.ShowDialog(_browseFileOptions))
            {
                PatchName = _browseFileOptions.FileNames.First().Name;

                PatchRecords = new ReadOnlyCollection<BinaryElementRecord<IpsValueElement>>(_scanner.Scan(_browseFileOptions.FileNames.First().FullName));
            }
        }

        private void BrowseFile()
        {
            //  _openFileDialogService.ShowDialog(_browseFileOptions);
        }

        //private void SelectPatch(BinaryRecord element)
        //{
        //    if (_fileData != null)
        //    {
        //        long offset = 0;
        //        long size = 0;

        //        if (element is IpsValueElement)
        //        {
        //            offset = (long)((IpsValueElement)element).WriteOffset;
        //            size = (long)((IpsValueElement)element).Length;
        //            hexView.SelectionStart = 0;
        //            hexView.BringIntoView();
        //            hexView.SelectionStart = offset;
        //            hexView.SelectionStop = size;
        //        }

        //        try
        //        {
        //            toolStripStatusLabelRows.Text = string.Format(Strings.Row, fastObjectListViewRows.SelectedIndex + 1, fastObjectListViewRows.Items.Count, size);
        //        }
        //        catch
        //        {
        //            toolStripStatusLabelRows.Text = string.Empty;
        //        }
        //    }
        //    else if (element is IpsValueElement)
        //    {
        //        int size = 0;
        //        //hexView.ByteShiftLeft = offset;

        //        hexView.CloseProvider();
        //        _dataStream?.Dispose();
        //        _dataStream = new MemoryStream();
        //        var data = ((IpsValueElement)element).GetData();
        //        var offset = ((IpsValueElement)element).WriteOffset;

        //        _dataStream.Write(data, 0, data.Length);
        //        hexView.Stream = _dataStream;

        //        size = ((IpsValueElement)element).Length;

        //        UpateDataViewToolStrip(true);
        //        try
        //        {
        //            toolStripStatusLabelRows.Text = string.Format(Strings.Row, fastObjectListViewRows.SelectedIndex + 1, fastObjectListViewRows.Items.Count, size);
        //        }
        //        catch
        //        {
        //            toolStripStatusLabelRows.Text = string.Empty;
        //        }
        //    }
        //    else
        //    {
        //        copyRowToolStripMenuItem.Enabled = false;
        //        toolStripButtonCopyRow.Enabled = false;
        //        toolStripStatusLabelRows.Text = string.Empty;
        //        _dataStream?.Dispose();
        //        UpateDataViewToolStrip(false);
        //    }
        //    fastObjectListViewRows.Focus();
        //}

        public bool CloseRequested
        {
            get => _closeRequested;
            set => _closeRequested = value;
        }

        public ReactiveCommand<Unit, Unit> RequestClose
        {
            get => _requestClose;
            set => _requestClose = value;
        }

        public RoutingState Router => _router;

        public ViewModelActivator Activator => _activator;

        public ReactiveCommand<Unit, Unit> CloseFile
        {
            get => _closeFile;
            set => _closeFile = value;
        }

        public ReactiveCommand<Unit, Unit> ClosePatch
        {
            get => _closePatch;
            set => _closePatch = value;
        }

        public ReactiveCommand<Unit, Unit> CloseTable
        {
            get => _closeTable;
            set => _closeTable = value;
        }

        public ReactiveCommand<Unit, Unit> CopyDisabledPatchRecords
        {
            get => _copyDisabledPatchRecords;
            set => _copyDisabledPatchRecords = value;
        }

        public ReactiveCommand<Unit, Unit> CopyEnablesPatchRecords
        {
            get => _copyEnablesPatchRecords;
            set => _copyEnablesPatchRecords = value;
        }

        public ReactiveCommand<Unit, Unit> CopySelectedFileDataAsHex
        {
            get => _copySelectedFileDataAsHex;
            set => _copySelectedFileDataAsHex = value;
        }

        public ReactiveCommand<Unit, Unit> CopySelectedFileDataAsString
        {
            get => _copySelectedFileDataAsString;
            set => _copySelectedFileDataAsString = value;
        }

        public ReactiveCommand<Unit, Unit> CopySelectedPatchRecords
        {
            get => _copySelectedPatchRecords;
            set => _copySelectedPatchRecords = value;
        }

        public ReactiveCommand<Unit, Unit> ExportSelectedPatchRecordListAsText
        {
            get => _exportSelectedPatchRecordListAsText;
            set => _exportSelectedPatchRecordListAsText = value;
        }

        public Stream DataStream
        {
            get => _dataStream;

            set => this.RaiseAndSetIfChanged(ref _dataStream, value);
        }

        public int[] FileName
        {
            get => _fileName;
            set => _fileName = value;
        }

        public string FilePath
        {
            get => _filePath;

            set => this.RaiseAndSetIfChanged(ref _filePath, value);
        }

        public ReactiveCommand<Unit, Unit> FindNextFileDataCommand
        {
            get => _findNextFileDataCommand;
            set => _findNextFileDataCommand = value;
        }

        public ReactiveCommand<Unit, Unit> FindPreviousFileDataCommand
        {
            get => _findPreviousFileDataCommand;
            set => _findPreviousFileDataCommand = value;
        }

        public bool HexViewVisible
        {
            get => _hexViewVisible;
            set => _hexViewVisible = value;
        }

        public ReactiveCommand<Unit, Unit> HideHexViewCommand
        {
            get => _hideHexViewCommand;
            set => _hideHexViewCommand = value;
        }

        public ReactiveCommand<Unit, Unit> HideStringViewCommand
        {
            get => _hideStringViewCommand;
            set => _hideStringViewCommand = value;
        }

        public ReactiveCommand<Unit, Unit> BrowseFileCommand
        {
            get => _browseFileCommand;
            set => _browseFileCommand = value;
        }

        public ReactiveCommand<Unit, Unit> BrowsePatchCommand
        {
            get => _browsePatchCommand;
            set => _browsePatchCommand = value;
        }

        public ReactiveCommand<Unit, Unit> BrowseTableCommand
        {
            get => _browseTableCommand;
            set => _browseTableCommand = value;
        }

        public byte[] PatchData
        {
            get => _patchData;

            set => this.RaiseAndSetIfChanged(ref _patchData, value);
        }

        public string PatchName
        {
            get => _patchName;
            set => this.RaiseAndSetIfChanged(ref _patchName, value);
        }

        public ReadOnlyCollection<BinaryElementRecord<IpsValueElement>> PatchRecords
        {
            get => _patchRecords;
            set => this.RaiseAndSetIfChanged(ref _patchRecords, value);
        }

        public ReactiveCommand<Unit, Unit> SelectAllData
        {
            get => _selectAllData;
            set => _selectAllData = value;
        }

        public byte[] SelectedData
        {
            get => _selectedData;
            set => _selectedData = value;
        }

        public int SelectedPatchRecordRow
        {
            get => _selectedPatchRecordRow;
            set => _selectedPatchRecordRow = value;
        }

        public ReactiveCommand<Unit, Unit> ShowFileDataHexView
        {
            get => _showFileDataHexView;
            set => _showFileDataHexView = value;
        }

        public ReactiveCommand<Unit, Unit> ShowGoToDataOffset
        {
            get => _showGoToDataOffset;
            set => _showGoToDataOffset = value;
        }

        public ReactiveCommand<Unit, Unit> ShowHexView
        {
            get => _showHexView;
            set => _showHexView = value;
        }

        public ReactiveCommand<Unit, Unit> ShowHorizontalLayout
        {
            get => _showHorizontalLayout;
            set => _showHorizontalLayout = value;
        }

        public ReactiveCommand<Unit, Unit> ShowLanguageView
        {
            get => _showLanguageView;
            set => _showLanguageView = value;
        }

        public ReactiveCommand<Unit, Unit> ShowSettings
        {
            get => _showSettings;
            set => _showSettings = value;
        }

        public ReactiveCommand<Unit, Unit> ShowStringHexView
        {
            get => _showStringHexView;
            set => _showStringHexView = value;
        }

        public ReactiveCommand<Unit, Unit> ShowToolbar
        {
            get => _showToolbar;
            set => _showToolbar = value;
        }

        public ReactiveCommand<Unit, Unit> ShowVerticalLayout
        {
            get => _showVerticalLayout;
            set => _showVerticalLayout = value;
        }

        public bool StringViewVisible
        {
            get => _stringViewVisible;
            set => _stringViewVisible = value;
        }

        public int[] TableName
        {
            get => _tableName;
            set => _tableName = value;
        }

        public int[] TablePath
        {
            get => _tablePath;
            set => _tablePath = value;
        }

        public int FileSize
        {
            get => _fileSize;
            set => _fileSize = value;
        }

        public int PatchCount
        {
            get => _patchCount;
            set => _patchCount = value;
        }

        public int SelectedPatchCount
        {
            get => _selectedPatchCount;
            set => _selectedPatchCount = value;
        }

        public bool Visible
        {
            get => _visible;
            set => _visible = value;
        }

        public bool IsVerticalLayout
        {
            get => _isVerticalLayout;
            set => _isVerticalLayout = value;
        }
    }
}