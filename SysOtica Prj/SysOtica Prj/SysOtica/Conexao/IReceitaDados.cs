using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Conexao
{
    interface IReceitaDados
    {
        void inserirReceita(Receita receita, Cliente cli);
        void alterarReceita(Receita receita);
        void excluirreceita(Receita receita);
        bool verificaduplicidade(Receita receita);
        List<Receita> listaReceita();
        void pesquisaReceitas(DataGridView grid, string cl_nome);
    }
}
