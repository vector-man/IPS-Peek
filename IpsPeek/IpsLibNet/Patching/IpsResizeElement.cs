using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("Resize")]
    public class IpsResizeElement : IpsElement
    {
        private int _size;
        public IpsResizeElement(int size, Range ipsFileRange, int ipsFileSize, byte[] data)
            : base(ipsFileRange, ipsFileSize, data)
        {
            _size = size;
        }
        public int Size
        {
            get
            {
                return _size;
            }
        }
    }
}
