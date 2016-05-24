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
using SysOtica.Conexao;

namespace WebServiceSysOtica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private IProdutoDados produto;
        private IVendaDados venda;
        private IClienteDados cliente;
        private IReceitaDados receita;
        private IUsuarioDados usuario;
        private IFornecedorDados fornecedor;
        private ICategoriaDados categoria;

        public Service1()
        {
            produto = new ProdutoDados();
            venda = new VendaDados();
            cliente = new ClienteDados();
            receita = new ReceitaDados();
            usuario = new UsuarioDados();
            fornecedor = new FornecedoresDados();
            categoria = new CategoriaDados();
        }

        #region Produto

        public void InserirProduto(Produto p)
        {
            produto.inserirProduto(p);
        }
        public void AlterarProduto(Produto p)
        {
            produto.alterarProduto(p);
        }
        public void excluirProduto(Produto p)
        {
            produto.excluirProduto(p);
        }
        public List<Produto> pesquisaProduto(string pr_descricao)
        {
            return produto.pesquisarProduto(pr_descricao);
        }
        public List<Produto> listarProduto()
        {
            return produto.listarProduto();
        }

        #endregion

        #region Venda

        public void inserir(Venda v)
        {
            venda.inserir(v);
        }


        #endregion

        #region Cliente

        public void alterarCliente(Cliente c)
        {
            cliente.alterarCliente(c);
        }
        public void inserirCliente(Cliente c)
        {
            cliente.inserirCliente(c);
        }
        public void excluirCliente(Cliente c)
        {
            cliente.excluirCliente(c);
        }
        public List<Cliente> pesquisarCliente(string cl_nome)
        {
            return cliente.pesquisarCliente(cl_nome);
        }
        public List<Cliente> listarCliente()
        {
            return cliente.listarCliente();
        }
        public List<Cliente> getCliente(int cl_id)
        {
            return cliente.getCliente(cl_id);
        }

        #endregion

        #region Receita

        public void InserirReceita(Receita r)
        {
            receita.inserirReceita(r);
        }
        public void AlterarReceita(Receita r)
        {
            receita.alterarReceita(r);
        }
        public void ExcluirReceita(Receita r)
        {
            receita.excluirreceita(r);
        }
        public List<Receita> PuxaReceita(string cl_nome)
        {
            return receita.puxaReceita(cl_nome);
        }
        public List<Receita> ListaReceita()
        {
            return receita.listaReceita();
        }
        public List<Receita> vendaReceita()
        {
            return receita.vendaReceita();
        }
        #endregion

        #region Usuario

        public void InserirUsuario(Usuario usu)
        {
            usuario.inserirUsuario(usu);

        }
        public void AlterarUsuario(Usuario usu)
        {

            usuario.alteraUsuario(usu);
        }
        public void ExcluirUsuario(Usuario usu)
        {
            usuario.deleteUsuario(usu);

        }
        public List<Usuario> PesquisaUsuario(string us_nome)
        {
            return usuario.pesquisaUsuario(us_nome);

        }
        public List<Usuario> ListaUsuario()
        {
            return usuario.listaUsuario();

        }


        #endregion

        #region Fornecedor

        public void InserirFornecedor(Fornecedor fr)
        {
            fornecedor.inserirFornecedor(fr);

        }
        public void AlterarFornecedor(Fornecedor fr)
        {

            fornecedor.alteraFornecedor(fr);
        }
        public void excluirFornecedor(Fornecedor fr)
        {
            fornecedor.excluiFornecedor(fr);

        }
        public List<Fornecedor> pesquisaFornecedor(string fr_razaosocial)
        {
            return fornecedor.pesquisarFornecedor(fr_razaosocial);

        }
        public List<Fornecedor> ListaFornecedor()
        {
            return fornecedor.listaFornecedor();

        }
        #endregion

        #region Categoria

        public void cadastraCat(Categoria cat)
        {

            categoria.inserirCategoria(cat);

        }
        public List<Categoria> pesquisaCategoria()
        {

            return categoria.pesquisaCategoria();
        }
        #endregion

    }
}
