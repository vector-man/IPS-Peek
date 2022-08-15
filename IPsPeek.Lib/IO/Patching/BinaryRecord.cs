namespace IpsPeek.Lib.IO.Patching
{
    public class BinaryRecord
    {
        public BinaryRecord(int offset, int length)
        {
            Offset = offset;
            Length = length;
        }

        public int Offset { get; }

        public int End => Offset + Length - 1;

        public int Length { get; }
    }
}