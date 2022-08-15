using System.Security.Cryptography;

namespace IpsPeek.Lib.IO.Patching
{
    public class IpsValueElement : IValueElement, IWritable
    {
        public IpsValueElement(int? offset, byte[] value)
        {
            Value = value;
            Offset = offset;
            Length = Value.Length;
        }

        public int? Offset { get; }

        public int? End => Length + Offset - 1;

        public int? Length { get; }

        public byte[] Value { get; set; }

        public void Write(System.IO.Stream stream, int offset)
        {
            stream.Seek(offset, System.IO.SeekOrigin.Begin);

            stream.Write(Value, (int)Offset, Value.Length);
        }

        public void Write(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}