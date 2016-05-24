using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Excecoes
{
   public class ClienteInvalidoException: Exception
    {
        public string Mensagem;
        public ClienteInvalidoException(string message) : base(message)
        {
            this.Mensagem = message;
        }

    }
}
