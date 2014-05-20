using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Be.Windows.Forms
{
    class HighlightComparer: IComparer<Highlight>
    {
        public int Compare(Highlight x, Highlight y)
        {
             // Check if value is below range (less than min).
            if (x.Offset.CompareTo(y.Offset) > 0)
            {
                return 1;
            }

            // Check if value is below range (less than min).
            if ((x.Length + x.Offset).CompareTo(y.Length + y.Offset) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}
