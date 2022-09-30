using System.Runtime.Serialization;

namespace ValueTypes
{
    [Serializable]
    internal class SchuelerzahlException : Exception
    {
        public SchuelerzahlException()
        {
        }

        public SchuelerzahlException(string? message) : base(message)
        {
        }

        public SchuelerzahlException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SchuelerzahlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}