using System.Collections.ObjectModel;
using System.IO;
using System.Reactive;
using IpsPeek.IO.Patching;
using ReactiveUI;

namespace IpsPeek.ViewModels
{
    public interface IMainViewModel : IWindow, IScreen, IActivatableViewModel
    {
        ReactiveCommand<Unit, Unit> CloseFile { get; set; }

        /// <summary>
        ///     Closes the currently opened Patch, clearing Patches property data.
        /// </summary>
        ReactiveCommand<Unit, Unit> ClosePatch { get; set; }

        ReactiveCommand<Unit, Unit> CloseTable { get; set; }

        /// <summary>
        ///     Copies disabled patch records to clipboard.
        /// </summary>
        ReactiveCommand<Unit, Unit> CopyDisabledPatchRecords { get; set; }

        /// <summary>
        ///     Copies enabled patch records to clipboard.
        /// </summary>
        ReactiveCommand<Unit, Unit> CopyEnablesPatchRecords { get; set; }

        ReactiveCommand<Unit, Unit> CopySelectedFileDataAsHex { get; set; }

        ReactiveCommand<Unit, Unit> CopySelectedFileDataAsString { get; set; }

        /// <summary>
        ///     Copies selected patch records to clipboard.
        /// </summary>
        ReactiveCommand<Unit, Unit> CopySelectedPatchRecords { get; set; }

        /// <summary>
        ///     Exports Patches as text list.
        /// </summary>
        ReactiveCommand<Unit, Unit> ExportSelectedPatchRecordListAsText { get; set; }
       
        Stream DataStream { get; set; }

        int[] FileName { get; set; }

        string FilePath { get; set; }

        ReactiveCommand<Unit, Unit> FindNextFileData { get; set; }

        ReactiveCommand<Unit, Unit> FindPreviousFileData { get; set; }

        bool HexViewVisible { get; set; }

        ReactiveCommand<Unit, Unit> HideHexView { get; set; }

        ReactiveCommand<Unit, Unit> HideStringView { get; set; }

        ReactiveCommand<Unit, Unit> BrowseFile { get; set; }

        /// <summary>
        ///     Opens a patch file.
        /// </summary>
        ReactiveCommand<Unit, Unit> BrowsePatch { get; set; }

        ReactiveCommand<Unit, Unit> BrowseTable { get; set; }

        byte[] PatchData { get; set; }

        string PatchName { get; set; }

        ReadOnlyCollection<IpsElement> PatchRecords { get; set; }

        ReactiveCommand<Unit, Unit> SelectAllData { get; set; }

        byte[] SelectedData { get; set; }

        int SelectedPatchRecordRow { get; set; }

        ReactiveCommand<Unit, Unit> ShowFileDataHexView { get; set; }

        ReactiveCommand<Unit, Unit> ShowGoToDataOffset { get; set; }

        ReactiveCommand<Unit, Unit> ShowHexView { get; set; }

        ReactiveCommand<Unit, Unit> ShowHorizontalLayout { get; set; }

        ReactiveCommand<Unit, Unit> ShowLanguageView { get; set; }

        /// <summary>
        ///     Shows the settings for the application.
        /// </summary>
        ReactiveCommand<Unit, Unit> ShowSettings { get; set; }

        ReactiveCommand<Unit, Unit> ShowStringHexView { get; set; }
        ReactiveCommand<Unit, Unit> ShowToolbar { get; set; }
        ReactiveCommand<Unit, Unit> ShowVerticalLayout { get; set; }
        bool StringViewVisible { get; set; }
        int[] TableName { get; set; }
        int[] TablePath { get; set; }

        int FileSize { get; set; }

        int PatchCount { get; set; }

        int SelectedPatchCount { get; set; }

        bool Visible { get; set; }
        bool IsVerticalLayout{ get; set; }

    }
}