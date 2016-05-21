using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SysOtica;
using SysOtica.Negocio.Classes_Basicas;

namespace WebServiceSysOtica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        #region Produto
        [OperationContract]
        void InserirProduto(Produto p);
        [OperationContract]
        void AlterarProduto(Produto p);
        [OperationContract]
        void excluirProduto(Produto p);
        [OperationContract]
        List<Produto> pesquisaProduto(string pr_descricao);
        [OperationContract]
        List<Produto> listarProduto();
        #endregion

        #region Venda

        [OperationContract]
        void inserir(Venda v);

        #endregion

        #region Cliente
        [OperationContract]
        void alterarCliente(Cliente c);
        [OperationContract]
        void inserirCliente(Cliente c);
        [OperationContract]
        void excluirCliente(Cliente c);
        [OperationContract]
        List<Cliente> pesquisarCliente(string cl_nome);
        [OperationContract]
        List<Cliente> listarCliente();
        [OperationContract]
        List<Cliente> getCliente(int cl_id);

        #endregion

        #region Receita

        [OperationContract]
        void InserirReceita(Receita receita);

        [OperationContract]
        void AlterarReceita(Receita receita);

        [OperationContract]
        void ExcluirReceita(Receita receita);

        [OperationContract]
        List<Receita> PuxaReceita(string cl_nome);

        [OperationContract]
        List<Receita> ListaReceita();

        [OperationContract]
        List<Receita> vendaReceita();

        #endregion

        #region Usuario

        [OperationContract]
        void InserirUsuario(Usuario usu);

        [OperationContract]
        void AlterarUsuario(Usuario usu);

        [OperationContract]
        void ExcluirUsuario(Usuario usu);

        [OperationContract]
        List<Usuario> PesquisaUsuario(string us_nome);

        [OperationContract]
        List<Usuario> ListaUsuario();


        #endregion

        #region Fornecedor

        [OperationContract]
        void InserirFornecedor(Fornecedor fr);
        [OperationContract]
        void AlterarFornecedor(Fornecedor fr);
        [OperationContract]
        void excluirFornecedor(Fornecedor fr);
        [OperationContract]
        List<Fornecedor> pesquisaFornecedor(string fr_razaosocial);
        [OperationContract]
        List<Fornecedor> ListaFornecedor();
        #endregion

        #region Categoria

        [OperationContract]
        public void cadastraCat(Categoria categoria);

        [OperationContract]
        public List<Categoria> pesquisaCategoria();
        #endregion


    }
}