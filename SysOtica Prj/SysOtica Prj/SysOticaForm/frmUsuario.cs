using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOtica;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio;
using SysOtica.Negocio.Fachada;

namespace SysOticaForm
{
    public partial class frmUsuario : Form
    {

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
                Usuario usu = new Usuario();
                {
                    usu.Us_usuario = tbUsuario.Text;
                    usu.Us_senha = tbSenha.Text;
                    usu.Us_tipo = cmbTipo.SelectedItem.ToString();
                    usu.Us_nome = tbNome.Text;
                    usu.Us_endereco = tbEndereco.Text;
                    usu.Us_telefone = maskedTextBoxTelefone.Text;
                };
                Fachada fachada = new Fachada();
                fachada.InserirUsuario(usu);
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