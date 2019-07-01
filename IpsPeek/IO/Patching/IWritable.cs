using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IpsPeek.IO.Patching
{
    interface IWritable
    {
        void Write(Stream stream);
    }
}
