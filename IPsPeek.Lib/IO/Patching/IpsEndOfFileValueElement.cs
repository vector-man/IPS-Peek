using System.Text;

namespace IpsPeek.Lib.IO.Patching
{
    public class IpsEndOfFileValueElement : IpsValueElement
    {
        private const string EndOfFileText = "EOF";

        public IpsEndOfFileValueElement() : base(null, Encoding.ASCII.GetBytes(EndOfFileText))
        {
        }
    }
}