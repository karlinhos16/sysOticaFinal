using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio;
using SysOtica.Negocio.Fachada;

namespace WebServiceSysOtica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private Fachada fachada;


        public Service1()
        {
            fachada = new Fachada();
        }

        #region Produto

        public void InserirProduto(Produto p)                       
        {
            fachada.InserirProduto(p);
        }
        public void AlterarProduto(Produto p)                       
        {
            fachada.AlterarProduto(p);
        }
        public void excluirProduto(Produto p)                       
        {
            fachada.excluirProduto(p);
        }
        public List<Produto> pesquisaProduto(string pr_descricao)   
        {
            return fachada.pesquisaProduto(pr_descricao);
        }
        public List<Produto> listarProduto()                        
        {
            return fachada.listarProduto();
        }

        #endregion

        #region Venda

        public void inserir(Venda v)
        {
            fachada.inserir(v);
        }

        #endregion

        #region Cliente

        public void alterarCliente(Cliente c)                
        {
            fachada.alterarCliente(c);
        }
        public void inserirCliente(Cliente c)                
        {
            fachada.inserirCliente(c);
        }
        public void excluirCliente(Cliente c)                
        {
            fachada.excluirCliente(c);
        }
        public List<Cliente> pesquisarCliente(string cl_nome)
        {
            return fachada.pesquisarCliente(cl_nome);
        }
        public List<Cliente> listarCliente()                  
        {
            return fachada.listarCliente();
        }
        public List<Cliente> getCliente(int cl_id)                
        {
            return fachada.getCliente(cl_id);
        }

        #endregion

        #region Receita

        public void InserirReceita(Receita receita)     
        {
            fachada.InserirReceita(receita);
        }
        public void AlterarReceita(Receita receita)     
        {
            fachada.AlterarReceita(receita);
        }
        public void ExcluirReceita(Receita receita)     
        {
            fachada.ExcluirReceita(receita);
        }
        public List<Receita> PuxaReceita(string cl_nome)
        {
            return fachada.PuxaReceita(cl_nome);
        }
        public List<Receita> ListaReceita()             
        {
            return fachada.ListaReceita();
        }
        public List<Receita> vendaReceita()             
        {
            return fachada.vendaReceita();
        }
        #endregion







    }
}
