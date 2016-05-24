using SysOticaForm.WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmListaFornecedor : Form
    {
        private Service1Client webservice = new Service1Client();
        private List<Fornecedor> listaFornecedor = new List<Fornecedor>();

        public frmListaFornecedor()
        {
            InitializeComponent();
        }

        public void atualizaGrid()
        {
            dataGridFornecedor.DataSource = null;
            listaFornecedor = webservice.ListaFornecedor().ToList<Fornecedor>();
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
                    this.WindowState = FormWindowState.Minimized;
                    DialogResult dialog = frmForn.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        this.WindowState = FormWindowState.Normal;
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
                    webservice.excluirFornecedor(listaFornecedor.ElementAt(dataGridFornecedor.SelectedRows[0].Index));
                    MessageBox.Show("Fornecedor excluído com sucesso!");
                    atualizaGrid();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
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
            try
            {
                string caracteres = "^[ a-zA-Z]+$";
                if (textPesquisa.Text.Length < 3)
                {

                    MessageBox.Show("Por Favor, digite um nome com no mínimo 3 caracteres");
                    return;
                }
                if (!Regex.IsMatch(textPesquisa.Text, caracteres))
                {
                    MessageBox.Show("Este campo só aceita letras");
                    return;
                }

                if (textPesquisa.Text != "")
                {

                    dataGridFornecedor.DataSource = null;
                    dataGridFornecedor.AutoGenerateColumns = false;
                    dataGridFornecedor.DataSource = webservice.pesquisaFornecedor(textPesquisa.Text.Trim());

                    if (dataGridFornecedor.Rows.Count == 0)
                    {
                        MessageBox.Show("Fornecedor não cadastrado");
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Erro ao listar fornecedor!");

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridFornecedor.DataSource = null;
        }
    }


}

