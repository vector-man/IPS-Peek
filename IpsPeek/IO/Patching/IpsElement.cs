using IpsLibNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IO.Patching
{
    public class IpsElement
    {
        private int _ipsSize;
        private int _ipsOffset;
        public IpsElement(int ipsOffset, int ipsSize)
        {
            _ipsOffset = ipsOffset;
            _ipsSize = ipsSize;
        }
        public virtual int IpsOffset
        {
            get { return _ipsOffset; }
        }
        public virtual int IpsEnd
        {
            get { return IpsOffset + IpsSize - 1; }
        }
        public virtual int IpsSize
        {
            get { return _ipsSize; }
        }
    }
}
