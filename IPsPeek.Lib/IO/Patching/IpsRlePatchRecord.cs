namespace IpsPeek.Lib.IO.Patching
{
    public class IpsRleValueElement : IpsValueElement
    {
        public IpsRleValueElement(int offset, byte rleByte, int rleCount) : base(offset, Array.Empty<byte>())

        {
            RleByte = rleByte;
            RleCount = rleCount;
            Value = ParallelEnumerable.Repeat(RleByte, rleCount).ToArray();
        }

        public byte RleByte { get; }

        public int RleCount { get; }
    }
}