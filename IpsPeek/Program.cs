using System;
using System.IO.Abstractions;
using System.Windows.Forms;
using Griffin.Container;
using IpsPeek.Services;
using IpsPeek;
using IpsPeek.Vendor;
using IpsPeek.ViewModels;
using Splat;

namespace IpsPeek
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new ContainerRegistrar();
            container.RegisterModules(typeof(WindowsModule).Assembly);
            Locator.SetLocator(new GriffinDependancyResolver(container));
            Application.Run(Locator.Current.GetService<MainView>());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var ex = (Exception)e.ExceptionObject;

                MessageBox.Show("Whoops! Please contact the developers with the following"
                                + " information:\n\n" + ex.Message + ex.StackTrace,
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}