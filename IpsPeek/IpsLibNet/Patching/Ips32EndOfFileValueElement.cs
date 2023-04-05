using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Patching
{
    public class Ips32EndOfFileValueElement : IpsValueElement
    {
        const string _value = "EEOF";
        public Ips32EndOfFileValueElement(int ipsOffset)
            : base(ipsOffset, _value.Length, Encoding.ASCII.GetBytes(_value))
        {
        }
    }
}
