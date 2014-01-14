using IpsLibNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    class IpsElement
    {
        private Range _ipsFileRange;
        private int _ipsFileSize;
        private byte[] _data;
        public IpsElement(Range ipsFileRange, int ipsFileSize, byte[] data)
        {
            _ipsFileRange = ipsFileRange;
            _ipsFileSize = ipsFileSize;
            _data = data;
        }
        public Range IpssFileRange
        {
            get { return _ipsFileRange; }
        }
        public int IpsFileSize
        {
            get { return _ipsFileSize; }
        }
        public byte[] Data
        {
            get
            {
                return _data;
            }
        }
    }
}
