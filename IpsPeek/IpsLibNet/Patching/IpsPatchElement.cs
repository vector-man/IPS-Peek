using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    public class IpsPatchElement : IpsElement
    {
        private int _offset;
        private int _size;
        private byte[] _data;

        public IpsPatchElement(int offset, int ipsOffset, byte[] data)
            : base(ipsOffset, data.Length)
        {
            _offset = offset;
            _data = data;
            _size = data.Length;
            HeaderSize = 5;
        }
        public int Offset
        {
            get
            {
                return _offset;
            }
        }
        public int End
        {
            get
            {
                return Offset + Size;
            }
        }
        public virtual int Size
        {
            get
            {
                return _size;
            }
        }
        public virtual byte[] GetData()
        {
            return _data;
        }
        protected int HeaderSize
        {
            get;
            set;
        }
        public override int IpsSize
        {
            get
            {
                return base.IpsSize + HeaderSize;
            }
        }
    }
}
