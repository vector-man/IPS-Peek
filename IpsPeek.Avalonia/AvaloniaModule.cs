using System;
using System.Data;
using System.IO.Abstractions;
using Autofac;
using IpsPeek.Avalonia.Services;
using IpsPeek.Avalonia.Views;
using IpsPeek.Lib.IO.Patching;
using IpsPeek.UI.Services;
using IpsPeek.UI.ViewModels;
using ReactiveUI;
using ContainerBuilder = Autofac.ContainerBuilder;

namespace IpsPeek.Avalonia
{
    public class AvaloniaModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // builder.RegisterType<CommandBinderImplementation>().As
            builder.Register<IOpenFileDialogService>((x) =>
            {
                var context = x.Resolve<IComponentContext>();

                return new OpenFileDialogService(() => context.Resolve<MainWindow>(), x.Resolve<IFileSystem>());
            });

            base.Load(builder);
        }
    }
}