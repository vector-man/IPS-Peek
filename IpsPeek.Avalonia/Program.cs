using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using System;
using System.Reactive.PlatformServices;
using Splat;
using System.IO.Abstractions;
using System.Reflection;
using Griffin.Container;
using ReactiveUI;

namespace IpsPeek.Avalonia
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            //var container = new ContainerRegistrar();
            //container.RegisterModules(typeof(CommonModule).Assembly);
            //Locator.SetLocator(new GriffinDependancyResolver(container));
            //Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
    }
}