using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("RES")]
    public class IpsResizeElement : IpsValueElement
    {
        private int _size = 0;
        public IpsResizeElement(int ipsOffset, byte[] value)
            : base(ipsOffset, value.Length, value)
        {
            _size = value.Length;
        }
        public int GetIntValue()
        {
            byte[] value = new byte[0];
            base.Value.CopyTo(value, 0);
            if ((BitConverter.IsLittleEndian))
            {
                Array.Reverse(value);
            }
            return BitConverter.ToInt32(value, 0);
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
