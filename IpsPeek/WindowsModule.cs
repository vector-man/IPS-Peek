using System;
using System.Data;
using System.IO.Abstractions;
using System.Windows.Forms;
using Griffin.Container;
using IpsLibNet;
using IpsPeek.IO;
using IpsPeek.IO.Patching;
using IpsPeek.Services;
using IpsPeek.ViewModels;
using ReactiveUI;

namespace IpsPeek
{
    public class WindowsModule : IContainerModule
    {
        public void Register(IContainerRegistrar registrar)
        {
            //ReactiveUI.
            //registrar.RegisterConcrete<CommandBinderImplementation>(Lifetime.Transient);

            //// Settings.
            //// registrar.RegisterType<IWindowsSettings, WindowsSettings>(Lifetime.Singleton);
            //registrar.RegisterType<IFileSystem, FileSystem>(Lifetime.Singleton);
            //registrar.RegisterType<IpsPatchScanner, IpsPatchScanner>(Lifetime.Singleton);

            // Services.
            //registrar.RegisterService<Func<IViewFor, Filesystem<Applier>>>(c => owner => new EngineProfileDialogService<Applier>(() => owner, () => c.Resolve<EngineProfileView>(), c.Resolve<IAsyncFileSystem>()), Lifetime.Transient);
            //registrar.RegisterService<Func<IViewFor, EngineProfileDialogService<Creator>>>(c => owner => new EngineProfileDialogService<Creator>(() => owner, () => c.Resolve<EngineProfileView>(), c.Resolve<IAsyncFileSystem>()), Lifetime.Transient);

            //// TypeConverters.
            //registrar.RegisterConcrete<AsyncPathTypeConverter>(Lifetime.Transient);
            //registrar.RegisterConcrete<DialogResultTypeConverter>(Lifetime.Transient);
            //registrar.RegisterConcrete<FileExtensionsTypeConverter>(Lifetime.Transient);
            //registrar.RegisterConcrete<ProgressBarStateTypeConverter>(Lifetime.Transient);
            //registrar.RegisterConcrete<DecimalTypeConverter>(Lifetime.Transient);

            //// Misc.
            //registrar.RegisterService(c => new DefaultImageListFactory().CreateInstance(), Lifetime.Singleton);
            // MainView.

            //registrar.RegisterService(c =>
            //{
            //    var owner = new MainView();
            //    owner.ViewModel = new MainViewModel(new OpenFileDialogService(() => owner, c.Resolve<IFileSystem>()),
            //        c.Resolve<IFileSystem>(), c.Resolve<IpsPatchScanner>());

            //    //Services.Settings.Tracker.Configure(owner).Apply();
            //    //Services.Settings.Tracker.Configure(c.Resolve<IWindowsSettings>()).Apply();
            //    // TODO: Replace with Windows Settings
            //    //Services.Settings.Tracker.Configure(c.Resolve<ISettings>()).Apply();

            //    return owner;
            //}, Lifetime.Transient);

            // HexDialog.
            //registrar.RegisterType<DataView, DataView>(Lifetime.Transient);
            //registrar.RegisterService<Func<DataView>>(c => () => c.Resolve<DataView>(), Lifetime.Singleton);

            // ProcessDialog.
            //registrar.RegisterService(c =>
            //{
            //    ProcessView owner = new ProcessView(c.Resolve<ImageList>())
            //    {
            //        ViewModel = new ProcessViewModel()
            //    };

            //    return owner;
            //}, Lifetime.Transient);

            // ProcessDialog.
            //registrar.RegisterService(c =>
            //{
            //    FileSystem owner = new  Filesystem();

            //    return owner;
            //}, Lifetime.Transient);

            //// ProcessingDialog.
            //registrar.RegisterService(c =>
            //{
            //    ProcessingView owner = new ProcessingView(c.Resolve<ImageList>());
            //    owner.ViewModel = new ProcessingViewModel(c.Resolve<IPatchProcessor>(),
            //        new SkipCancelDialogService(() => owner),
            //        new AlertDialogService(() => owner));

            //    return owner;
            //}, Lifetime.Transient);

            //// SelectionDialog.
            //registrar.RegisterType<SelectionView, SelectionView>(Lifetime.Default);
            //registrar.RegisterService<Func<SelectionView>>(c => () => c.Resolve<SelectionView>(), Lifetime.Singleton);

            // BackendsView.
            //registrar.RegisterService<Func<BackendsView>>(c => () =>
            //    {
            //        BackendsView owner = new BackendsView();
            //        owner.ViewModel = new BackendsViewModel(
            //            c.Resolve<Func<IViewFor, EngineDialogService>>()(owner),
            //            c.Resolve<IBackendManager>());

            //        return owner;
            //    },
            //    Lifetime.Transient);
        }
    }
}