using System.Reflection;
using Autofac;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Avalonia.Threading;
using IpsPeek.Avalonia.Views;
using IpsPeek.UI.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;
using Splat;
using Splat.Autofac;

namespace IpsPeek.Avalonia
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            InitAutofac();
            AvaloniaXamlLoader.Load(this);
        }

        private void InitAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new CommonModule());
            builder.RegisterModule(new AvaloniaModule());

            builder.RegisterType<MainWindow>().AsSelf().SingleInstance();
            builder.RegisterType<MainViewModel>().AsSelf().SingleInstance();
            // Creates and sets the Autofac resolver as the Locator
            var autofacResolver = builder.UseAutofacDependencyResolver();
            autofacResolver.InitializeSplat();

            // Initialize ReactiveUI components
            autofacResolver.InitializeReactiveUI();

            // Register the resolver in Autofac so it can be later resolved
            builder.RegisterInstance(autofacResolver);

            // autofacResolver.SetLifetimeScope(builder.Build());

            //Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

            // If you need to override any service (such as the ViewLocator), register it after InitializeReactiveUI
            // https://autofaccn.readthedocs.io/en/latest/register/registration.html#default-registrations
            // builder.RegisterType<MyCustomViewLocator>().As<IViewLocator>().SingleInstance();

            RxApp.MainThreadScheduler = AvaloniaScheduler.Instance;
            //Locator.CurrentMutable.RegisterConstant(new AvaloniaActivationForViewFetcher(), typeof(IActivationForViewFetcher));
            //Locator.CurrentMutable.RegisterConstant(new AutoDataTemplateBindingHook(), typeof(IPropertyBindingHook));
            var container = builder.Build();

            var resolver = container.Resolve<AutofacDependencyResolver>();

            // Set a lifetime scope (either the root or any of the child ones) to Autofac resolver
            // This is needed, because the previous steps did not Update the ContainerBuilder since they became immutable in Autofac 5+
            // https://github.com/autofac/Autofac/issues/811
            resolver.SetLifetimeScope(container);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var mainViewModel = Locator.Current.GetService<MainViewModel>();
                var mainView = Locator.Current.GetService<MainWindow>();
                mainView!.DataContext = mainViewModel;
                desktop.MainWindow = mainView;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}