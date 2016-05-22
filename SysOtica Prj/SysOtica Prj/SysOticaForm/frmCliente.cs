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
using SysOticaForm.WebService;


namespace SysOticaForm
{
    public partial class frmCliente : Form
    {
        private WebService.Service1Client webservice = new WebService.Service1Client();
        private WebService.Cliente cliente = new WebService.Cliente();
        
        
        public frmCliente()
        {
            InitializeComponent();
          
        }
        public frmCliente(WebService.Cliente cl)
        {
            InitializeComponent();
            cliente = cl;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            cliente.Cl_nome = textBoxNome.Text;
            cliente.Cl_datanascimento = Convert.ToDateTime(dateTimePicker1.Text);
            cliente.Cl_cpf = textBoxCidade.Text;
            cliente.Cl_rg = textBoxCidade.Text;
            cliente.Cl_telefone = textBoxUF.Text;
            cliente.Cl_celular = textBoxCidade.Text;
            cliente.Cl_telefone2 = textBoxPais.Text;
            cliente.Cl_cep = maskedTextBoxCep.Text;
            cliente.Cl_endereco = textBoxEndereco.Text;
            cliente.Cl_numero = textBoxNumero.Text;
            cliente.Cl_bairro = textBoxBairro.Text;
            cliente.Cl_cidade = textBoxCidade.Text;
            cliente.Cl_uf = textBoxUF.Text;
            cliente.Cl_email = textBoxEmail.Text;
            cliente.Cl_nomepai = textBoxNomepai.Text;
            cliente.Cl_nomemae = textBoxNomemae.Text;
            cliente.Cl_profissao = textBoxProfissao.Text;
            cliente.Cl_observacoes = richTextBoxObservacoes.Text;



            try
            {
                webservice.inserirCliente(cliente);
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
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
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
