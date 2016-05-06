using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Regras_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Fachada
{


 
 
    public class Fachada : IFachada
    {

        # region Cliente
        ClienteDados dao = new ClienteDados();
        ClienteControlador contr = new ClienteControlador();
        
        public void alterarCliente(Cliente c)
        {
            contr.ValidarCamposVazios(c);
            dao.alterarCliente(c);
        }

        public void inserirCliente(Cliente c)
        {
            contr.ValidarCamposVazios(c);
            dao.inserirCliente(c);
        }

        public void  excluirCliente(Cliente c)
        {
            contr.ValidarCamposVazios(c);
            dao.excluirCliente(c);
        }

        public List<Cliente> pesquisarCliente(string cl_nome)
        {
            return dao.pesquisarCliente(cl_nome);
        }

        public List<Cliente> listarCliente()
        {
            return dao.listarCliente();
        }
        #endregion


        #region Fornecedor 

        
        FornecedoresDados frdao = new FornecedoresDados();
        FornecedorControlador fornColtrol = new FornecedorControlador();

        public void InserirFornecedor(Fornecedor fr)
        {
            fornColtrol.VerificaPreenchimento(fr);
            frdao.inserirFornecedor(fr);

        }

        public void AlterarFornecedor(Fornecedor fr)
        {

            fornColtrol.VerificaPreenchimento(fr);
            frdao.alteraFornecedor(fr);
        }


        public void excluirFornecedor(Fornecedor fr)
        {
            frdao.excluiFornecedor(fr);

        }

        public List<Fornecedor> pesquisaFornecedor(string fr_razaosocial)
        {
            return frdao.pesquisarFornecedor(fr_razaosocial);

        }

        public List<Fornecedor> ListaFornecedor()
        {
           return frdao.listaFornecedor();

        }
        #endregion


        #region Produto

        ProdutoDados pdao = new ProdutoDados();
        ProdutoControlador pColtrol = new ProdutoControlador();

        public void InserirProduto(Produto p)
        {
            pColtrol.verificaPreenchimento(p);
            pdao.inserirProduto(p);

        }

        public void AlterarProduto(Produto p)
        {

            pColtrol.verificaPreenchimento(p);
            pdao.alterarProduto(p);
        }


        public void excluirProduto(Produto p)
        {
            pdao.excluirProduto(p);

        }

        public List<Produto> pesquisaProduto(string pr_descricao)
        {
            return pdao.pesquisarProduto(pr_descricao);

        }

        public List<Produto> ListaProduto()
        {
            return pdao.listarProduto();

        }


        #endregion


        #region Receita

        ReceitaDados receitadao = new ReceitaDados();
        ReceitaControlador receitaColtrol = new ReceitaControlador();

        public void InserirReceita(Receita receita, Cliente cli)
        {
            receitaColtrol.VerificaPreenchimento(receita);
            receitadao.inserirReceita(receita, cli);

        }

        public void AlterarReceita(Receita receita)
        {

            receitaColtrol.VerificaPreenchimento(receita);
            receitadao.alterarReceita(receita);
        }


        public void ExcluirReceita(Receita receita)
        {
            receitadao.excluirreceita(receita);

        }

        public List<Receita> PesquisaReceita(string rc_nomemedico)
        {
            return receitadao.pesquisaReceita(rc_nomemedico);

        }

        public List<Receita> ListaReceita()
        {
            return receitadao.listaReceita();

        }






        #endregion


        #region Usuario

        UsuarioDados usudao = new UsuarioDados();
        UsuarioControlador usuControl = new UsuarioControlador();

        public void InserirUsuario(Usuario usu)
        {
             usuControl.VerificaPreenchimento(usu);
             usudao.inserirUsuario(usu);

        }


        public void AlterarUsuario(Usuario usu)
        {

            usuControl.VerificaPreenchimento(usu);
            usudao.alteraUsuario(usu);
        }


        public void ExcluirUsuario(Usuario usu)
        {
            usudao.deleteUsuario(usu);

        }

        public List<Usuario> PesquisaUsuario(string us_nome)
        {
            return usudao.pesquisaUsuario(us_nome);

        }

        public List<Usuario> ListaUsuario()
        {
            return usudao.listaUsuario();

        }


        #endregion

        #region Venda
        VendaDados venDados = new VendaDados();
        VendaControlador venControl = new VendaControlador();

        public void inserirVenda(Venda v)
        {
            venDados.inserirVenda(v);
        }

        public List<Venda> listarVenda()
        {
            return venDados.listarVenda();
        }

       
        #endregion

    }
}
