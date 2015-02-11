using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Westwind.Utilities.Configuration;

namespace IpsPeek
{
    internal class ApplicationConfiguration : AppConfiguration
    {
        private const string ConfigurationFileName = "config.json";

        public ApplicationConfiguration()
        {
            FirstRun = true;
        }

        private static readonly Lazy<ApplicationConfiguration> _instance =

            new Lazy<ApplicationConfiguration>(() => new ApplicationConfiguration());

        public static ApplicationConfiguration Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public bool FirstRun { get; set; }

        public Size FormSize { get; set; }

        public Point FormPosition { get; set; }

        public int PanelHeight { get; set; }

        public bool ToolBarVisible { get; set; }

        public bool DataViewVisible { get; set; }

        public bool StringViewVisible { get; set; }

        public byte[] ListViewState { get; set; }

        public List<string> TextItems { get; set; }

        public bool VerticalLayout { get; set; }

        public bool FormMaximized { get; set; }

        public string Emulator { get; set; }

        protected override IConfigurationProvider OnCreateDefaultProvider(string sectionName, object configData)
        {
            var provider = new JsonFileConfigurationProvider<ApplicationConfiguration>()
            {
                JsonConfigurationFile = Path.Combine(Application.StartupPath, ConfigurationFileName)
            };

            return provider;
        }
    }
}