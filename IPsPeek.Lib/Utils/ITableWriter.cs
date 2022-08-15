namespace IpsPeek.Lib.Utils
{
    public interface ITableWriter : IDisposable
    {
        void WriteRow(params Cell[] cells);
    }
}