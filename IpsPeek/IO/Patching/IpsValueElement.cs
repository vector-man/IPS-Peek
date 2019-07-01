using IpsLibNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IO.Patching
{
    public class IpsValueElement : IpsElement
    {
        private byte[] _value;
        public IpsValueElement(int ipsOffset, int ipsSize, byte[] value)
            : base(ipsOffset, ipsSize)
        {
            _value = value;
        }
        public byte[] Value
        {
            get
            {
                return _value;
            }
        }
    }
}
