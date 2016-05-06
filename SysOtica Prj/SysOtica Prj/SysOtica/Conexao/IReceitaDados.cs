using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface IReceitaDados
    {
        void inserirReceita(Receita receita);
        void alterarReceita(Receita receita);
        void excluirreceita(Receita receita);
        bool verificaduplicidade(Receita receita);
        List<Receita> listaReceita();
        List<Receita> pesquisaReceita(string rc_nomemedico);
    }
}
