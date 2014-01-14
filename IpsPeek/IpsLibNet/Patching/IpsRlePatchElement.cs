using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("RLE")]
    class IpsRlePatchElement : IpsPatchElement
    {
        public IpsRlePatchElement(int offset, int size, Range ipsFileRange, int ipsFileSize, byte[] data)
            : base(offset, size, ipsFileRange, ipsFileSize, data)
        {
        }
    }
}
