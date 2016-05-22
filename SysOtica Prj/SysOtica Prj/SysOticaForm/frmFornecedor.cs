using SysOticaForm.WebService;
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
    public partial class frmFornecedor : Form
    {
        private Service1Client webservice = new Service1Client();
        private Fornecedor fornecedor = new Fornecedor();

        public frmFornecedor()
        {
            InitializeComponent();
        }

      
         
        private void frmFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
         }
            public void LimparCampos()
          {
            textBoxRazaosocial.Text = "";
            maskedTextBoxCNPJ.Text = "";
            textBoxInscEstadual.Text = "";
            textBoxFantasia.Text = "";
            textBoxEndereco.Text = "";
            textBoxCidade.Text = "";
            textBoxUF.Text = "";
            textBoxBairro.Text = "";
            maskedTextBoxCEP.Text = "";
            textBoxContato.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxFax.Text = "";
            textBoxEmail.Text = "";
            textBoxNomeRep.Text = "";
            maskedTextBoxTelRep.Text = "";
            maskedTextBoxCelRep.Text = "";
            richTextBoxObservacoes.Text = "";
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonLimpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    fornecedor.Fr_razaosocial = textBoxRazaosocial.Text;
                    fornecedor.Fr_cnpj = maskedTextBoxCNPJ.Text;
                    fornecedor.Fr_inscricaoestadual = textBoxInscEstadual.Text;
                    fornecedor.Fr_fantasia = textBoxFantasia.Text;
                    fornecedor.Fr_endereco = textBoxEndereco.Text;
                    fornecedor.Fr_cidade = textBoxCidade.Text;
                    fornecedor.Fr_uf = textBoxUF.Text;
                    fornecedor.Fr_bairro = textBoxBairro.Text;
                    fornecedor.Fr_cep = maskedTextBoxCEP.Text;
                    fornecedor.Fr_contato = textBoxContato.Text;
                    fornecedor.Fr_telefone = maskedTextBoxTelefone.Text;
                    fornecedor.Fr_fax = textBoxFax.Text;
                    fornecedor.Fr_email = textBoxEmail.Text;
                    fornecedor.Fr_nomerepresentante = textBoxNomeRep.Text;
                    fornecedor.Fr_telefonerepresentante = maskedTextBoxTelRep.Text;
                    fornecedor.Fr_celularrepresentante = maskedTextBoxCelRep.Text;
                    fornecedor.Fr_observacoes = richTextBoxObservacoes.Text;
                }

                webservice.InserirFornecedor(fornecedor);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                LimparCampos();

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Erro no Cadastro do Fornecedor" + ex.Message);
            }

        }
    }
}
