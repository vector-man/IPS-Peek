using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Be.Windows.Forms
{
    public class Highlight
    {
        private SolidBrush _background;
        private SolidBrush _foreground;
        private long  _offset;
        private long _length;
        public Highlight(Color foreColor, Color backColor, long offset, long length)
        {
            _background = new SolidBrush(backColor);
            _foreground = new SolidBrush(foreColor);
            _offset = offset;
            _length = length;
        }
        public Color BackColor
        {
            get
            {
                return _background.Color;
            }
        }
        public Color ForeColor
        {
            get
            {
                return _foreground.Color;
            }
        }
        public SolidBrush Background
        {
            get
            {
                return _background;
            }
        }
        public SolidBrush Foreground
        {
            get
            {
                return _foreground;
            }
        }
        public long Offset
        {
            get
            {
                return _offset;
            }
        }
        public long Length
        {
            get { return _length; }
        }
    }
}
