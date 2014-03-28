using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IpsPeek.Reporting
{
   public interface IReporter: IDisposable
    {
        void Write(Dictionary<string, string> row);
    }
}
