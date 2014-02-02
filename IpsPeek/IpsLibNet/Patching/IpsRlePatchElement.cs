using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    public class IpsRlePatchElement : IpsPatchElement
    {
        private byte _rleByte;
        private int _rleCount;
        public IpsRlePatchElement(int offset, int ipsOffset, byte rleByte, int rleCount)
            : base(offset, ipsOffset, new byte[0])
        {
            _rleByte = rleByte;
            _rleCount = rleCount;
            HeaderSize = 8;
        }
        public byte Rlebyte
        {
            get
            {
                return _rleByte;
            }
        }
        public int RleCount
        {
            get
            {
                return _rleCount;
            }
        }
        public override int Size
        {
            get
            {
                return _rleCount;
            }
        }
        public override byte[] GetData()
        {
            return ParallelEnumerable.Repeat(_rleByte, _rleCount).ToArray();
        }

    }
}
