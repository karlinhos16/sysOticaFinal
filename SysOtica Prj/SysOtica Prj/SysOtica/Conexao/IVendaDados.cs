using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface IVendaDados
    {
        void inserirVenda(Venda v);
        //void alterarVenda(Venda v);
        //void excluirVenda(Venda v);
        List<Venda> listarVenda();
    }
}
