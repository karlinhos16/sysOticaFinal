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
    public partial class frmFornecedorAlterar : Form
    {
        private Service1Client webservice = new Service1Client();
        private Fornecedor fornecedor = new Fornecedor();

        public frmFornecedorAlterar(Fornecedor fr)
        {
            InitializeComponent();

            this.fornecedor = fr;

            if (fornecedor != null)
            {
                txtID.Text = Convert.ToString(fornecedor.Fr_id);
                textBoxRazaosocial.Text = fornecedor.Fr_razaosocial;
                maskedTextBoxCNPJ.Text = fornecedor.Fr_cnpj;
                textBoxInscEstadual.Text = fornecedor.Fr_inscricaoestadual;
                textBoxFantasia.Text = fornecedor.Fr_fantasia;
                textBoxEndereco.Text = fornecedor.Fr_endereco;
                textBoxCidade.Text = fornecedor.Fr_cidade;
                textBoxUF.Text = fornecedor.Fr_uf;
                txtBairro.Text = fornecedor.Fr_bairro;
                maskedTextBoxCEP.Text = fornecedor.Fr_cep;
                textBoxContato.Text = fornecedor.Fr_contato;
                maskedTextBoxTelefone.Text = fornecedor.Fr_telefone;
                textBoxFax.Text = fornecedor.Fr_fax;
                textBoxEmail.Text = fornecedor.Fr_email;
                textBoxNomeRep.Text = fornecedor.Fr_nomerepresentante;
                maskedTextBoxTelRep.Text = fornecedor.Fr_telefonerepresentante;
                maskedTextBoxCelRep.Text = fornecedor.Fr_celularrepresentante;
                richTextBoxObservacoes.Text = fornecedor.Fr_observacoes;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                    fornecedor.Fr_bairro = txtBairro.Text;
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
                if (fornecedor == null)
                {
                    webservice.AlterarFornecedor(fornecedor);
                    MessageBox.Show("Fornecedor alterado com sucesso!");
                    LimparCampos();
                }
                else
                {

                    fornecedor.Fr_id = Convert.ToInt32(txtID.Text);
                    fornecedor.Fr_razaosocial = textBoxRazaosocial.Text;
                    fornecedor.Fr_cnpj = maskedTextBoxCNPJ.Text;
                    fornecedor.Fr_inscricaoestadual = textBoxInscEstadual.Text;
                    fornecedor.Fr_fantasia = textBoxFantasia.Text;
                    fornecedor.Fr_endereco = textBoxEndereco.Text;
                    fornecedor.Fr_cidade = textBoxCidade.Text;
                    fornecedor.Fr_uf = textBoxUF.Text;
                    fornecedor.Fr_bairro = txtBairro.Text;
                    fornecedor.Fr_cep = maskedTextBoxCEP.Text;
                    fornecedor.Fr_contato = textBoxContato.Text;
                    fornecedor.Fr_telefone = maskedTextBoxTelefone.Text;
                    fornecedor.Fr_fax = textBoxFax.Text;
                    fornecedor.Fr_email = textBoxEmail.Text;
                    fornecedor.Fr_nomerepresentante = textBoxNomeRep.Text;
                    fornecedor.Fr_telefonerepresentante = maskedTextBoxTelRep.Text;
                    fornecedor.Fr_celularrepresentante = maskedTextBoxCelRep.Text;
                    fornecedor.Fr_observacoes = richTextBoxObservacoes.Text;

                    webservice.AlterarFornecedor(fornecedor);
                    MessageBox.Show("Fornecedor alterado com sucesso!");
                    LimparCampos();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }

        }

        void LimparCampos()
        {
            textBoxRazaosocial.Text = "";
            maskedTextBoxCNPJ.Text = "";
            textBoxInscEstadual.Text = "";
            textBoxFantasia.Text = "";
            textBoxEndereco.Text = "";
            textBoxCidade.Text = "";
            textBoxUF.Text = "";
            txtBairro.Text = "";
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

    }
}
