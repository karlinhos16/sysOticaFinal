using System;
using System.Runtime.Serialization;

namespace SysOticaForm
{
    [Serializable]
    internal class BancoDeDadosException : Exception
    {
        public BancoDeDadosException()
        {
        }

        public BancoDeDadosException(string message) : base(message)
        {
        }

        public BancoDeDadosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BancoDeDadosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}