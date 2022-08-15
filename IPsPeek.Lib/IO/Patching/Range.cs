namespace IpsPeek.Lib.IO.Patching
{
    public class Range
    {
        public Range(int rangeStart, int rangeStop)
        {
            this.RangeStart = rangeStart;
            this.RangeStop = rangeStop;
        }

        public int RangeStart { get; set; }

        public int RangeStop { get; set; }
    }
}