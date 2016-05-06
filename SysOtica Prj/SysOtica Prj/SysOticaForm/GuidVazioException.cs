using System;
using System.Runtime.Serialization;

namespace SysOticaForm
{
    [Serializable]
    internal class GuidVazioException : Exception
    {
        public GuidVazioException()
        {
        }

        public GuidVazioException(string message) : base(message)
        {
        }

        public GuidVazioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GuidVazioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}