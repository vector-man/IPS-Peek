using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using Avalonia.Controls;
using IpsPeek.UI.Services;
using ReactiveUI;

namespace IpsPeek.Avalonia.Services
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

        public bool ShowDialog(UI.Services.FileOpenOptions options)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = options.InitialDirectory,
                Title = options.Title,
                AllowMultiple = options.MultiSelect
            };
            var fileNames = dialog.ShowAsync((Window)_owner.Invoke()).Result;

            if (fileNames?.Length == 0) return false;

            options.FileNames = fileNames.Select(x => new FileInfoWrapper(_fileSystem, new FileInfo(x))).ToArray();

            return true;
        }
    }
}