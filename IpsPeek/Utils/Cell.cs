using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.Utils
{
    public class Cell
    {
        public Cell(string text, int minWidth)
        {
            Text = text;
            MinWidth = minWidth;
        }
        public string Text
        {
            get;
            set;
        }
        public int MinWidth
        {
            get;
            set;
        }
        public int Padding
        {
            get;
            set;
        }
    }
}
