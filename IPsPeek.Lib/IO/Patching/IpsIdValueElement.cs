using System.Text;

namespace IpsPeek.Lib.IO.Patching
{
    public class IpsIdValueElement : IpsValueElement
    {
        private const string IdText = "PATCH";

        public IpsIdValueElement() : base(null, Encoding.ASCII.GetBytes(IdText))
        {
        }
    }
}