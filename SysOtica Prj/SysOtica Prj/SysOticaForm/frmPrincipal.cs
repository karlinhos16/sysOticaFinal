using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmPrincipal : Form
    {
        public static frmPrincipal mdiobj;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsuario usuario = new frmUsuario();
            usuario.MdiParent = this;
            usuario.Show();


        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCliente cliente = new frmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.MdiParent = this;
            fornecedor.Show();

        }



        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProduto produto = new formProduto();
            produto.MdiParent = this;
            produto.Show();
        }




        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceita receita = new frmReceita();
            receita.MdiParent = this;
            receita.Show();
        }



        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarCliente listarclientes = new frmListarCliente();
            listarclientes.MdiParent = this;
            listarclientes.Show();

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaFornecedor listarfornecedores = new frmListaFornecedor();
            listarfornecedores.MdiParent = this;
            listarfornecedores.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarUsuario listarUsuarios = new frmListarUsuario();
            listarUsuarios.MdiParent = this;
            listarUsuarios.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProduto listarProdutos = new frmListarProduto();
            listarProdutos.MdiParent = this;
            listarProdutos.Show();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarReceita listarReceitas = new frmListarReceita();
            listarReceitas.MdiParent = this;
            listarReceitas.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teste tt = new teste();
            tt.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategoria frmCategoria = new formCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void produtoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntradaMovimentacao frmEntrada = new frmEntradaMovimentacao();
            frmEntrada.MdiParent = this;
            frmEntrada.Show();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusForms.FormVenda == null)
            {
                MeusForms.FormVenda = new frmVenda();
                MeusForms.FormVenda.MdiParent = this;
                MeusForms.FormVenda.Show();
                MeusForms.FormVenda.Focus();
            }
        }
    }
}
