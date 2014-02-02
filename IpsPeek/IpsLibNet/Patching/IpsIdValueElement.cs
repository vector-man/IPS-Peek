using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    public class IpsIdValueElement : IpsValueElement
    {
        const string _value = "PATCH";
        public IpsIdValueElement(int ipsOffset)
            : base(ipsOffset, _value.Length, Encoding.ASCII.GetBytes(_value))
        {
        }
    }
}
