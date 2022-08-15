namespace IpsPeek.Lib.IO.Patching;

public class BinaryElementRecord<T> : BinaryRecord where T : class, IValueElement
{
    public BinaryElementRecord(int offset, int length, T elementElement) :
        base(offset, length)
    {
        Element = elementElement;
    }

    public T Element { get; }
}