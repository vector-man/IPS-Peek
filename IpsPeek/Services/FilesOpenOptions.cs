using System.Collections.Generic;
using System.IO.Abstractions;

namespace IpsPeek.Services
{
    public class FileOpenOptions
    {
        public IEnumerable<IFileInfo> FileNames { get; set; }

        public string Filter { get; set; }

        public int FilterIndex { get; set; }

        public string InitialDirectory { get; set; }

        public bool MultiSelect { get; set; }

        public string Title { get; set; }
    }
}