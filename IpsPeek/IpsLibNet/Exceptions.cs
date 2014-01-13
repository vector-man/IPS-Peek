using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Exceptions
{



    public class UnsupportedFileTypeException : Exception
    {

        public UnsupportedFileTypeException()
        {
        }
        public UnsupportedFileTypeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
    public class MalformedPatchException : Exception
    {

        public MalformedPatchException()
        {
        }
        public MalformedPatchException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
    public class NoEndOfFileException : Exception
    {
        public NoEndOfFileException()
        {
        }

        public NoEndOfFileException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class FileTooLargeException : Exception
    {

        public FileTooLargeException()
        {
        }
        public FileTooLargeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class OffsetOutOfRangeException : Exception
    {

        public OffsetOutOfRangeException()
        {
        }
        public OffsetOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}



