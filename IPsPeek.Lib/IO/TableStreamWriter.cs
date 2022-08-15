using System.Text;

namespace IpsPeek.Lib.Utils
{
    public class TableStreamWriter : StreamWriter, ITableWriter
    {
        public TableStreamWriter(Stream stream)
            : base(stream)
        {
        }

        public void WriteRow(params Cell[] cells)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Cell cell in cells)
            {
                builder.Append(string.Format("{0," + -(Math.Max(cell.Text.Length, cell.MinWidth) + cell.Padding) + "}", cell.Text));
            }
            WriteLine(builder);
        }

        void IDisposable.Dispose()
        {
            base.Dispose();
        }
    }
}