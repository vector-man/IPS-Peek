using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IpsPeek.Utils
{
    public interface ITableWriter: IDisposable
    {
         void WriteRow(params Cell[] cells);
    }
}
