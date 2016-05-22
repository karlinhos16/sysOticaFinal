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
    public partial class frmUsuario : Form
    {

        private Service1Client webservice = new Service1Client();
        private Usuario usuario = new Usuario();

        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
        public void LimpaCampos()
        {
            tbUsuario.Text = "";
            tbSenha.Text = "";
            cmbTipo.Text = "";
            tbNome.Text = "";
            tbEndereco.Text = "";
            maskedTextBoxTelefone.Text = "";

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    usuario.Us_usuario = tbUsuario.Text;
                    usuario.Us_senha = tbSenha.Text;
                    usuario.Us_tipo = cmbTipo.SelectedItem.ToString();
                    usuario.Us_nome = tbNome.Text;
                    usuario.Us_endereco = tbEndereco.Text;
                    usuario.Us_telefone = maskedTextBoxTelefone.Text;
                };
                webservice.InserirUsuario(usuario);
                MessageBox.Show("Cadastro feito com Sucesso !");
                LimpaCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar com o Banco de Dados! " + ex.Message);
            }
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}