using System;
using System.Runtime.Serialization;

namespace SysOticaForm
{
    [Serializable]
    internal class ConexaoException : Exception
    {
        public ConexaoException()
        {
        }

        public ConexaoException(string message) : base(message)
        {
        }

        public ConexaoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConexaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}