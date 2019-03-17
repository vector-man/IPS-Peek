using Jot.DefaultInitializer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IpsPeek
{
    public class ApplicationConfiguration
    {
        [Trackable]
        public int PanelHeight { get; set; } = 165;
        [Trackable]
        public bool ToolBarVisible { get; set; } = true;
        [Trackable]
        public bool DataViewVisible { get; set; } = true;
        public bool StringViewVisible { get; set; } = true;
        [Trackable]
        public byte[] ListViewState { get; set; }

        [Trackable]
        public List<string> TextItems { get; set; } = new List<string>();
        [Trackable]
        public bool VerticalLayout { get; set; } = true;

        [Trackable]
        public string Emulator { get; set; }


    }
}