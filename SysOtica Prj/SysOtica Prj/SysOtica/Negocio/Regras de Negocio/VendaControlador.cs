using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class VendaControlador
    {

        public void ValorDivergente(Venda v)
        {

            if (v.Vn_desconto == v.Vn_valor)
            {
                throw new CampoVazioException("Desconto não pode ser 100%!");
            }


        }

        }
}
