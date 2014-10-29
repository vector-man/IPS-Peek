using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace IpsPeek.Options
{
    public class OptionsModel
    {
        public int FormWidth { get; set; }
        public int FormHeight { get; set; }
        public int FormTop { get; set; }
        public int FormLeft { get; set; }
        public int PanelHeight { get; set; }
        public bool ToolBarVisible { get; set; }
        public bool DataViewVisible { get; set; }
        public bool StringViewVisible { get; set; }
        public byte[] ListView { get; set; }
        public string[] TextItems { get; set; }
        public bool VerticalLayout { get; set; }
        public bool Maximized { get; set; }
        public string Emulator { get; set; }
    }
}
