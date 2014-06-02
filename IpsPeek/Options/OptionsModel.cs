using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace IpsPeek.Options
{
    public class OptionsModel
    {
        public OptionsModel()
        {

        }
        public OptionsModel(int formWidth, int formHeight, int formTop, int formLeft, int panelHeight, bool toolBarVisible, bool dataViewVisible, bool stringViewVisible, byte[] listView, string[] textItems, bool verticalLayout, bool maximized)
        {
            this.FormWidth = formWidth;
            this.FormHeight = formHeight;
            this.FormTop = formTop;
            this.FormLeft = FormLeft;
            this.PanelHeight = panelHeight;
            this.ToolBarVisible = toolBarVisible;
            this.DataViewVisible = dataViewVisible;
            this.StringViewVisible = stringViewVisible;
            this.ListView = listView;
            this.TextItems = textItems;
            this.VerticalLayout = verticalLayout;
            this.Maximized = maximized;
        }
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
    }
}
