using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
namespace IpsLibNet
{
    public enum IpsPatchType
    {
        [Description("Patch")]
        Patch = 1,
        [Description("RLE Patch")]
        RlePatch = 2,
        [Description("ID")]
        Id = 3,
        [Description("EOF")]
        Eof = 4,
        [Description("Resize")]
        Resize = 5
    }
    public class IpsPatch
    {

        private int? _offset;
        private int? _size;
        private Range _ipsPatchRange;
        private int? _ipsFileSize;
        private IpsPatchType _patchType;
        private byte[] _data;
        public IpsPatch(int? offset, int? size, Range ipsPatchRange, int ipsFileSize, IpsPatchType patchType, byte[] data)
        {
            this._offset = offset;
            this._size = size;
            this._ipsPatchRange = ipsPatchRange;
            this._ipsFileSize = ipsFileSize;
            this._patchType = patchType;
            this._data = data;


        }
        public int? Offset
        {
            get { return _offset; }
        }

        public int? Size
        {
            get { return _size; }
        }

        public Range IpsPatchRange
        {
            get { return _ipsPatchRange; }
        }

        public int? IpsFileSize
        {
            get { return _ipsFileSize; }
        }
        public IpsPatchType PatchType
        {
            get { return _patchType; }
        }
        public byte[] data
        {
            get
            {
                return _data;
            }
        }
    }
}

