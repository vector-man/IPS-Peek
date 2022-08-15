using System.ComponentModel;

namespace IpsPeek.Lib.IO.Patching
{
    public enum IpsPatchRecordType
    {
        [Description("Patch")]
        Patch = 1,

        [Description("RLE")]
        RlePatch = 2,

        [Description("ID")]
        Id = 3,

        [Description("EOF")]
        Eof = 4,

        [Description("Resize")]
        Resize = 5
    }
}