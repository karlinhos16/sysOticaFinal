using SysOtica;
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
    public partial class frmFornecedor : Form
    {
        Fachada fachadaFornecedor = new Fachada();


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
                Fornecedor fr = new Fornecedor();
                {
                    fr.Fr_razaosocial = textBoxRazaosocial.Text;
                    fr.Fr_cnpj = maskedTextBoxCNPJ.Text;
                    fr.Fr_inscricaoestadual = textBoxInscEstadual.Text;
                    fr.Fr_fantasia = textBoxFantasia.Text;
                    fr.Fr_endereco = textBoxEndereco.Text;
                    fr.Fr_cidade = textBoxCidade.Text;
                    fr.Fr_uf = textBoxUF.Text;
                    fr.Fr_bairro = textBoxBairro.Text;
                    fr.Fr_cep = maskedTextBoxCEP.Text;
                    fr.Fr_contato = textBoxContato.Text;
                    fr.Fr_telefone = maskedTextBoxTelefone.Text;
                    fr.Fr_fax = textBoxFax.Text;
                    fr.Fr_email = textBoxEmail.Text;
                    fr.Fr_nomerepresentante = textBoxNomeRep.Text;
                    fr.Fr_telefonerepresentante = maskedTextBoxTelRep.Text;
                    fr.Fr_celularrepresentante = maskedTextBoxCelRep.Text;
                    fr.Fr_observacoes = richTextBoxObservacoes.Text;
                }

                fachadaFornecedor.InserirFornecedor(fr);
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
