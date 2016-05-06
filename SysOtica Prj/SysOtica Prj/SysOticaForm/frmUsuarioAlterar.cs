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
    public partial class frmUsuarioAlterar : Form
    {
        Usuario alteraUsuario;
        Fachada fachada = new Fachada();


        public frmUsuarioAlterar(Usuario usu) 
        {
            InitializeComponent();

            this.alteraUsuario = usu;

            if (alteraUsuario != null)

            {

                textIDusuario.Text = Convert.ToString(alteraUsuario.Us_id);
                tbUsuario.Text = alteraUsuario.Us_usuario;
                tbSenha.Text = alteraUsuario.Us_senha;
                cmbTipo.Text = alteraUsuario.Us_tipo;
                tbNome.Text = alteraUsuario.Us_nome;
                tbEndereco.Text = alteraUsuario.Us_endereco;
                maskedTextBoxTelefone.Text = alteraUsuario.Us_telefone;

            
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



        private void btnSalvar_Click(object sender, EventArgs e)
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

                }
                if (alteraUsuario == null)
                {
                    fachada.AlterarUsuario(usu);
                    MessageBox.Show("Usuario alterado com sucesso!");
                    LimpaCampos();
                }
                else
                {
                    alteraUsuario.Us_usuario = tbUsuario.Text;
                    alteraUsuario.Us_senha = tbSenha.Text;
                    alteraUsuario.Us_tipo = cmbTipo.SelectedItem.ToString();
                    alteraUsuario.Us_nome = tbNome.Text;
                    alteraUsuario.Us_endereco = tbEndereco.Text;
                    alteraUsuario.Us_telefone = maskedTextBoxTelefone.Text;

                    fachada.AlterarUsuario(alteraUsuario);
                    MessageBox.Show("Usuario alterado com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                    LimpaCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

    }
}
