using SysOtica.Negocio;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Fachada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmCliente : Form
    {
        Fachada fachada = new Fachada();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Cl_nome = textBoxNome.Text;
            c.Cl_datanascimento = Convert.ToDateTime(dateTimePicker1.Text);
            c.Cl_cpf = textBoxCidade.Text;
            c.Cl_rg = textBoxCidade.Text;
            c.Cl_telefone = textBoxUF.Text;
            c.Cl_celular = textBoxCidade.Text;
            c.Cl_telefone2 = textBoxPais.Text;
            c.Cl_cep = maskedTextBoxCep.Text;
            c.Cl_endereco = textBoxEndereco.Text;
            c.Cl_numero = textBoxNumero.Text;
            c.Cl_bairro = textBoxBairro.Text;
            c.Cl_cidade = textBoxCidade.Text;
            c.Cl_uf = textBoxUF.Text;
            c.Cl_email = textBoxEmail.Text;
            c.Cl_nomepai = textBoxNomepai.Text;
            c.Cl_nomemae = textBoxNomemae.Text;
            c.Cl_profissao = textBoxProfissao.Text;
            c.Cl_observacoes = richTextBoxObservacoes.Text;



            try
            {
                fachada.inserirCliente(c);
                textBoxNome.Clear();
                textBoxCPF.Clear();
                textBoxRg.Clear();
                maskedTextBoxTelefone.Clear();
                maskedTextBoxCelular.Clear();
                maskedTextBoxTelefone2.Clear();
                maskedTextBoxCep.Clear();
                textBoxEndereco.Clear();
                textBoxNumero.Clear();
                textBoxBairro.Clear();
                textBoxCidade.Clear();
                textBoxUF.Clear();
                textBoxEmail.Clear();
                textBoxNomepai.Clear();
                textBoxNomemae.Clear();
                textBoxProfissao.Clear();
                richTextBoxObservacoes.Clear();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (SqlException ex)
            {
                throw new ConexaoException("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void LimparCampos()
        {
            textBoxNome.Text = "";
            dateTimePicker1.Text = "";
            textBoxCPF.Text = "";
            textBoxRg.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCelular.Text = "";
            maskedTextBoxTelefone2.Text = "";
            maskedTextBoxCep.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxEmail.Text = "";
            textBoxNomepai.Text = "";
            textBoxNomemae.Text = "";
            textBoxProfissao.Text = "";
            richTextBoxObservacoes.Text = "";
            textBoxUF.Text = "";
        }
    }
}
