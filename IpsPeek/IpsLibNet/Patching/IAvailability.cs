using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
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
