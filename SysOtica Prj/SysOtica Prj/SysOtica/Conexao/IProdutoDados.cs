using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface IProdutoDados
    {
        void inserirProduto(Produto p);
        void alterarProduto(Produto p);
        void excluirProduto(Produto p);
        List<Produto> listarProduto();

    }
}
