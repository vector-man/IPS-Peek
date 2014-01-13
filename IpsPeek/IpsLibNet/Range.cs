using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace IpsLibNet
{
    public class Range
    {

        public Range(int rangeStart, int rangeStop)
        {
            this.RangeStart = rangeStart;
            this.RangeStop = rangeStop;
        }
        public int RangeStart { get; set; }

        public int RangeStop { get; set; }

    }
}
