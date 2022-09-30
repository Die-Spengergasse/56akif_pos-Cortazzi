using System.Runtime.Serialization;

namespace ValueTypes
{
    [Serializable]
    internal class NotZeroException : Exception
    {
        public NotZeroException()
        {
        }

        public NotZeroException(string? message) : base(message)
        {
        }

        public NotZeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}