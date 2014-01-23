using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    [DisplayName("EOF")]
    public class IpsEndOfFileElement : IpsValueElement
    {
        const string _value = "EOF";
        public IpsEndOfFileElement(int ipsOffset)
            : base(ipsOffset, _value.Length, Encoding.ASCII.GetBytes(_value))
        {
        }
    }
}
