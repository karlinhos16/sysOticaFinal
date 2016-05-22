using SysOticaForm.WebService;
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
    public partial class frmListarCliente : Form
    {

        private Service1Client webservice = new Service1Client();
        private List<Cliente> listarCliente = new List<Cliente>();

        public frmListarCliente()
        {
            InitializeComponent();
        }

        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCliente.DataSource = webservice.listarCliente();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                atualizaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void atualizaGrid()
        {
            dataGridViewCliente.DataSource = null;
            listarCliente = webservice.listarCliente().ToList<Cliente>();
            dataGridViewCliente.DataSource = listarCliente;
            dataGridViewCliente.Update();
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCliente.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para alterar!");
                    return;
                }
                DialogResult resultado = MessageBox.Show("Deseja realmente alterar esse Cliente? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Cliente cliSelecionado;
                    cliSelecionado = (dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente);

                    formClienteAlterar formal = new formClienteAlterar(cliSelecionado);
                    DialogResult dialog = formal.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        atualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            try
            {
                if (dataGridViewCliente.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma Linha para excluir!");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Cliente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    webservice.excluirCliente(listarCliente.ElementAt(dataGridViewCliente.SelectedRows[0].Index));
                    MessageBox.Show("Funcionário excluído com sucesso!");
                    atualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }
        }
        private void dataGridViewCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCliente.SelectedRows[0].Index >= 0)
            {
                MessageBox.Show("Campo Selecionado!");
                Cliente cliSelecionado = listarCliente.ElementAt(dataGridViewCliente.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Campo não selecionado!");
            }
        }
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCliente.DataSource = webservice.pesquisarCliente(buttonPesquisar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}