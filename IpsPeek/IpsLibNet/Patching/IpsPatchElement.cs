using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("Patch")]
    class IpsPatchElement : IpsElement
    {
        private int _offset;
        private int _size;
        public IpsPatchElement(int offset, int size, Range ipsFileRange, int ipsFileSize, byte[] data)
            : base(ipsFileRange, ipsFileSize, data)
        {
            _offset = offset;
        }
        public int Offset
        {
            get
            {
                return _offset;
            }
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
