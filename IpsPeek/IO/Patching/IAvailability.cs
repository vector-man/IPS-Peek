using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IO.Patching
{
    interface IAvailability
    {
        bool Enabled
        {
            get;
            set;
        }
    }
}
