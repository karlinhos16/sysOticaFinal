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
    public partial class frmListarUsuario : Form
    {
        public List<Usuario> listarUsuario;
        Fachada fachada = new Fachada();



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
            listarUsuario = fachada.ListaUsuario();
            dataGridUsuario.DataSource = listarUsuario;
            dataGridUsuario.Update();


        }



        private void dataGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridUsuario.SelectedRows[0].Index >= 0)
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
                    DialogResult dialog = formUs.ShowDialog();

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
                    fachada.ExcluirUsuario(listarUsuario.ElementAt(dataGridUsuario.SelectedRows[0].Index));
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
            dataGridUsuario.DataSource = fachada.PesquisaUsuario(btnPesquisa.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
