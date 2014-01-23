using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("ID")]
    public class IpsIdElement : IpsValueElement
    {
        const string _value = "PATCH";
        public IpsIdElement(int ipsOffset)
            : base(ipsOffset, _value.Length, Encoding.ASCII.GetBytes(_value))
        {
        }
    }
}
