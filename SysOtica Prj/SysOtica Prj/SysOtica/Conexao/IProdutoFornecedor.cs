using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface IProdutoFornecedor
    {

        void inserir(ProdutoFornecedor pf);
        List<ProdutoFornecedor> selecionafornecedor();
        List<ProdutoFornecedor> selecionaproduto(int pr_id);

    }
}
