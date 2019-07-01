using System;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Windows.Forms;
using ReactiveUI;

namespace IpsPeek.Services
{
    public class OpenFileDialogService : IOpenFileDialogService
    {
        private readonly Func<IViewFor> _owner;
        private IFileInfo[] _files;
        private IFileSystem _fileSystem;

        public OpenFileDialogService(Func<IViewFor> owner, IFileSystem fileSystem)
        { 
            _owner = owner;
            _fileSystem = fileSystem;
        }

        public bool ShowDialog(FileOpenOptions options)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = options.Filter,
                FilterIndex = options.FilterIndex,
                InitialDirectory = options.InitialDirectory,
                Title = options.Title,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = options.MultiSelect
            })
            {
                if (dialog.ShowDialog((IWin32Window) _owner()) == DialogResult.OK)
                {
                    var fileNames = dialog.FileNames;

                    if (dialog.FileName.Length != 0)
                    {
                        options.FileNames = new[] {new FileInfoWrapper(_fileSystem, new FileInfo(fileNames[0]))};
                    }
                    else
                    {
                        options.FileNames = fileNames.Select(x => new FileInfoWrapper(_fileSystem, new FileInfo(x))).ToArray();
                    }
                }
                else
                {
                    return false;
                }

                return true;
            }
        }
    }
}