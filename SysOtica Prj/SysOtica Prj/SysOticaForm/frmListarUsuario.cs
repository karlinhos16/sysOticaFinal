using SysOticaForm.WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmListarUsuario : Form
    {
        private Service1Client webservice = new Service1Client();
        private List<Usuario> listarUsuario = new List<Usuario>();

        public frmListarUsuario()
        {
            InitializeComponent();
        }



        private void frmListarUsuario_Load(object sender, EventArgs e)
        {

        }

        void atualizaGrid()
        {
            dataGridUsuario.AutoGenerateColumns = false;
            dataGridUsuario.DataSource = null;
            listarUsuario = webservice.ListaUsuario().ToList<Usuario>();
            dataGridUsuario.DataSource = listarUsuario;
            dataGridUsuario.Update();

        }

        private void dataGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridUsuario.SelectedRows[0].Index >= -1)
            {
                MessageBox.Show("Campo Selecionado!");
                Usuario usuSelecionado = listarUsuario.ElementAt(dataGridUsuario.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Campo não selecionado!");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUsuario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para alterar!");
                    return;
                }
                DialogResult resultado = MessageBox.Show("Deseja realmente alterar esse Usuario? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Usuario usuSelecionado;
                    usuSelecionado = (dataGridUsuario.SelectedRows[0].DataBoundItem as Usuario);

                    frmUsuarioAlterar formUs = new frmUsuarioAlterar(usuSelecionado);
                    this.WindowState = FormWindowState.Minimized;
                    DialogResult dialog = formUs.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        this.WindowState = FormWindowState.Normal;
                        atualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            try
            {
                if (dataGridUsuario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma Linha para excluir!");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Usuario?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    webservice.ExcluirUsuario(listarUsuario.ElementAt(dataGridUsuario.SelectedRows[0].Index));
                    MessageBox.Show("Usuario excluído com sucesso!");
                    atualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }


        }

        private void btnPesquisa_Click(object sender, EventArgs e)
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

                    dataGridUsuario.DataSource = null;
                    dataGridUsuario.AutoGenerateColumns = false;
                    dataGridUsuario.DataSource = webservice.PesquisaUsuario(textPesquisa.Text.Trim());


                }
            }
            catch
            {
                MessageBox.Show("Erro listar Usuario");

            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
