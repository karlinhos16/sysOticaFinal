using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Excecoes
{
    class ConexaoException : Exception
    {
        public string Mensagem;
        public ConexaoException(string message) : base(message)
        {
            this.Mensagem = message;
        }
    }
}
