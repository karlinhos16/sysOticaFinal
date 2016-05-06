using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Fachada;
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
    public partial class frmListaFornecedor : Form
    {
       public List<Fornecedor> listaFornecedor;
        Fachada fachada = new Fachada();

        public frmListaFornecedor()
        {
            InitializeComponent();
        }

        public void atualizaGrid()
        {
            dataGridFornecedor.DataSource = null;
            listaFornecedor = fachada.ListaFornecedor();
            dataGridFornecedor.DataSource = listaFornecedor;
            dataGridFornecedor.Update();
        }




        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
         

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridFornecedor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para alterar!");
                    return;
                }
                DialogResult resultado = MessageBox.Show("Deseja realmente alterar esse Fornecedor? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Fornecedor frSelecionado;
                    frSelecionado = (dataGridFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);

                    frmFornecedorAlterar frmForn = new frmFornecedorAlterar(frSelecionado);
                    DialogResult dialog =  frmForn.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        atualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Falha na comunicação com o banco de dados do Fornecedor \n" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor fr = new Fornecedor();

            try
            {
                if (dataGridFornecedor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma Linha para excluir!");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Fornecedor?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    fachada.excluirFornecedor(listaFornecedor.ElementAt(dataGridFornecedor.SelectedRows[0].Index));
                    MessageBox.Show("Fornecedor excluído com sucesso!");
                    atualizaGrid();
                }
            }
            catch (Exception ex)
            {
                throw new GuidVazioException("Falha na comunicação com o banco de dados do Fornecedor. \n" + ex.Message);
            }
        }

        private void dataGridFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridFornecedor.SelectedRows[0].Index >= 0)
            {
                MessageBox.Show("Campo Selecionado!");
                Fornecedor fornSelecionado = listaFornecedor.ElementAt(dataGridFornecedor.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Campo não selecionado!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)              
        {
            dataGridFornecedor.DataSource = fachada.pesquisarCliente(btnPesquisar.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }


}

