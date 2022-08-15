using System;
using System.Data;
using System.IO.Abstractions;
using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using IpsPeek.Lib.IO.Patching;
using IpsPeek.UI.Services;
using IpsPeek.UI.ViewModels;
using ReactiveUI;

namespace IpsPeek
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //ReactiveUI.
            //  registrar.RegisterConcrete<CommandBinderImplementation>(Lifetime.Transient);

            // Settings.
            // registrar.RegisterType<IWindowsSettings, WindowsSettings>(Lifetime.Singleton);
            builder.RegisterType<FileSystem>().As<IFileSystem>();
            builder.RegisterType<IpsPatchScanner>().As<IpsPatchScanner>();
        }
    }
}