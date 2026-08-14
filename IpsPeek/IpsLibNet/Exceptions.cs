using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpsPeek.IpsLibNet.Exceptions
{
    /// <summary>
    /// The exception that is thrown when the file type is not supported.
    /// </summary>
    public class UnsupportedFileTypeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsupportedFileTypeException"/> class.
        /// </summary>
        public UnsupportedFileTypeException()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsupportedFileTypeException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public UnsupportedFileTypeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    /// <summary>
    /// The exception that is thrown when the patch file is malformed.
    /// </summary>
    public class MalformedPatchException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MalformedPatchException"/> class.
        /// </summary>
        public MalformedPatchException()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MalformedPatchException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public MalformedPatchException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    /// <summary>
    /// The exception that is thrown when the end of file is not found in the patch file.
    /// </summary>
    public class NoEndOfFileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoEndOfFileException"/> class.
        /// </summary>
        public NoEndOfFileException()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoEndOfFileException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public NoEndOfFileException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    /// <summary>
    /// The exception that is thrown when the file is too large to be processed.
    /// </summary>
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
    /// <summary>
    /// The exception that is thrown when the offset is out of range.
    /// </summary>
    public class OffsetOutOfRangeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffsetOutOfRangeException"/> class.
        /// </summary>
        public OffsetOutOfRangeException()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="OffsetOutOfRangeException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public OffsetOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}



