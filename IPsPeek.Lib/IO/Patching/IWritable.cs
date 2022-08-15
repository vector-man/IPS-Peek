namespace IpsPeek.Lib.IO.Patching
{
    internal interface IWritable
    {
        public void Write(System.IO.Stream stream, int offset);

        void Write(Stream stream);
    }
}