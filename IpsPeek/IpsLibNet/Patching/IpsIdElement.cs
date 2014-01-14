using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("ID")]
    class IpsIdElement : IpsElement
    {
        public IpsIdElement(Range ipsFileRange, int ipsFileSize, byte[] data)
            : base(ipsFileRange, ipsFileSize, data)
        {
        }
    }
}
