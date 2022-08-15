namespace IpsPeek.Lib.Reporting
{
    public interface IReporter : IDisposable
    {
        void Write(Dictionary<string, string> row);
    }
}