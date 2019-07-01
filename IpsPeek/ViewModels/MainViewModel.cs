using IpsPeek.IO.Patching;
//using IpsPeek.IO;
using IpsPeek.Services;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Reactive;

namespace IpsPeek.ViewModels
{
    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        private readonly IFileSystem _fileSystem;
        private readonly IOpenFileDialogService _openFileDialogService;

        private Stream _dataStream;
        private string _filePath;
        private byte[] _patchData;

        public MainViewModel(IOpenFileDialogService openFileDialogService,
            IFileSystem fileSystem,
            IIpsScanner scanner)
        {
            _openFileDialogService = openFileDialogService;
            _fileSystem = fileSystem;

            this.WhenActivated(d =>
            {

                // ReactiveCommand creation:
                d(RequestClose = ReactiveCommand.Create(() =>
                {
                    CloseRequested = true;
                }, this.WhenAnyValue(x => x.CloseRequested, x => !x), RxApp.MainThreadScheduler));

                d(BrowseFile = ReactiveCommand.Create(() =>
                {
                    FileOpenOptions options = new FileOpenOptions();

                    if (_openFileDialogService.ShowDialog(options))
                    {
                        var fileName = options.FileNames.First();

                        FilePath = fileName.FullName;

                        DataStream = new MemoryStream(File.ReadAllBytes(FilePath));
                    }
                }, null, RxApp.MainThreadScheduler));
            });
        }


        //private void SelectPatch(IpsElement element)
        //{
        //    if (_fileData != null)
        //    {
        //        long offset = 0;
        //        long size = 0;

        //        if (element is IpsPatchElement)
        //        {
        //            offset = (long)((IpsPatchElement)element).Offset;
        //            size = (long)((IpsPatchElement)element).Size;
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
        //    else if (element is IpsPatchElement)
        //    {
        //        int size = 0;
        //        //hexView.ByteShiftLeft = offset;

        //        hexView.CloseProvider();
        //        _dataStream?.Dispose();
        //        _dataStream = new MemoryStream();
        //        var data = ((IpsPatchElement)element).GetData();
        //        var offset = ((IpsPatchElement)element).Offset;

        //        _dataStream.Write(data, 0, data.Length);
        //        hexView.Stream = _dataStream;

        //        size = ((IpsPatchElement)element).Size;


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


        public bool CloseRequested { get; set; }
        public ReactiveCommand<Unit, Unit> RequestClose { get; set; }
        public RoutingState Router { get; }
        public ViewModelActivator Activator { get; } = new ViewModelActivator();
        public ReactiveCommand<Unit, Unit> CloseFile { get; set; }
        public ReactiveCommand<Unit, Unit> ClosePatch { get; set; }
        public ReactiveCommand<Unit, Unit> CloseTable { get; set; }
        public ReactiveCommand<Unit, Unit> CopyDisabledPatchRecords { get; set; }
        public ReactiveCommand<Unit, Unit> CopyEnablesPatchRecords { get; set; }
        public ReactiveCommand<Unit, Unit> CopySelectedFileDataAsHex { get; set; }
        public ReactiveCommand<Unit, Unit> CopySelectedFileDataAsString { get; set; }
        public ReactiveCommand<Unit, Unit> CopySelectedPatchRecords { get; set; }
        public ReactiveCommand<Unit, Unit> ExportSelectedPatchRecordListAsText { get; set; }
        public Stream DataStream
        {
            get => _dataStream;

            set => this.RaiseAndSetIfChanged(ref _dataStream, value);
        }
        public int[] FileName { get; set; }

        public string FilePath
        {
            get => _filePath;

            set => this.RaiseAndSetIfChanged(ref _filePath, value);
        }
        public ReactiveCommand<Unit, Unit> FindNextFileData { get; set; }
        public ReactiveCommand<Unit, Unit> FindPreviousFileData { get; set; }
        public bool HexViewVisible { get; set; }
        public ReactiveCommand<Unit, Unit> HideHexView { get; set; }
        public ReactiveCommand<Unit, Unit> HideStringView { get; set; }
        public ReactiveCommand<Unit, Unit> BrowseFile { get; set; }
        public ReactiveCommand<Unit, Unit> BrowsePatch { get; set; }
        public ReactiveCommand<Unit, Unit> BrowseTable { get; set; }
        public byte[] PatchData
        {
            get => _patchData;

            set => this.RaiseAndSetIfChanged(ref _patchData, value);
        }
        public string PatchName { get; set; }
        public ReadOnlyCollection<IpsElement> PatchRecords { get; set; }
        public ReactiveCommand<Unit, Unit> SelectAllData { get; set; }
        public byte[] SelectedData { get; set; }

        public int SelectedPatchRecordRow { get; set; }
        public ReactiveCommand<Unit, Unit> ShowFileDataHexView { get; set; }
        public ReactiveCommand<Unit, Unit> ShowGoToDataOffset { get; set; }
        public ReactiveCommand<Unit, Unit> ShowHexView { get; set; }
        public ReactiveCommand<Unit, Unit> ShowHorizontalLayout { get; set; }
        public ReactiveCommand<Unit, Unit> ShowLanguageView { get; set; }
        public ReactiveCommand<Unit, Unit> ShowSettings { get; set; }
        public ReactiveCommand<Unit, Unit> ShowStringHexView { get; set; }
        public ReactiveCommand<Unit, Unit> ShowToolbar { get; set; }
        public ReactiveCommand<Unit, Unit> ShowVerticalLayout { get; set; }
        public bool StringViewVisible { get; set; }
        public int[] TableName { get; set; }
        public int[] TablePath { get; set; }
        public int FileSize { get; set; }
        public int PatchCount { get; set; }
        public int SelectedPatchCount { get; set; }
        public bool Visible { get; set; }
        public bool IsVerticalLayout { get; set; }
    }

}
