using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    public class IpsResizeValueElement : IpsValueElement, IWritable, IAvailability
    {
        private int _size = 0;
        public IpsResizeValueElement(int ipsOffset, byte[] value)
            : base(ipsOffset, value.Length, value)
        {
            _size = value.Length;
        }
        public int GetIntValue()
        {
            byte[] value = new byte[4];
            base.Value.CopyTo(value, 1);
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

        public void Write(System.IO.Stream stream)
        {
            if (!Enabled) return;

            stream.Seek(0, System.IO.SeekOrigin.Begin);
            stream.SetLength(GetIntValue());
        }
        public bool Enabled
        {
            get;
            set;
        }
    }
}
