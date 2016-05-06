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
    public partial class frmFornecedorAlterar : Form
    {
        Fornecedor AlteraFornecedor;
        Fachada fachada = new Fachada();

        public frmFornecedorAlterar(Fornecedor fr)
        {
            InitializeComponent();

            this.AlteraFornecedor = fr;

            if (AlteraFornecedor != null)
            {
                txtID.Text = Convert.ToString(AlteraFornecedor.Fr_id);
                textBoxRazaosocial.Text = AlteraFornecedor.Fr_razaosocial;
                maskedTextBoxCNPJ.Text = AlteraFornecedor.Fr_cnpj;
                textBoxInscEstadual.Text = AlteraFornecedor.Fr_inscricaoestadual;
                textBoxFantasia.Text = AlteraFornecedor.Fr_fantasia;
                textBoxEndereco.Text = AlteraFornecedor.Fr_endereco;
                textBoxCidade.Text = AlteraFornecedor.Fr_cidade;
                textBoxUF.Text = AlteraFornecedor.Fr_uf;
                txtBairro.Text = AlteraFornecedor.Fr_bairro;
                maskedTextBoxCEP.Text = AlteraFornecedor.Fr_cep;
                textBoxContato.Text = AlteraFornecedor.Fr_contato;
                maskedTextBoxTelefone.Text = AlteraFornecedor.Fr_telefone;
                textBoxFax.Text = AlteraFornecedor.Fr_fax;
                textBoxEmail.Text = AlteraFornecedor.Fr_email;
                textBoxNomeRep.Text = AlteraFornecedor.Fr_nomerepresentante;
                maskedTextBoxTelRep.Text = AlteraFornecedor.Fr_telefonerepresentante;
                maskedTextBoxCelRep.Text = AlteraFornecedor.Fr_celularrepresentante;
                richTextBoxObservacoes.Text = AlteraFornecedor.Fr_observacoes;


            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                    fr.Fr_bairro = txtBairro.Text;
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
                if (AlteraFornecedor == null)
                {
                    fachada.AlterarFornecedor(fr);
                    MessageBox.Show("Fornecedor alterado com sucesso!");
                    LimparCampos();
                }
                else
                {


                    AlteraFornecedor.Fr_id = Convert.ToInt32(txtID.Text);
                    AlteraFornecedor.Fr_razaosocial = textBoxRazaosocial.Text;
                    AlteraFornecedor.Fr_cnpj = maskedTextBoxCNPJ.Text;
                    AlteraFornecedor.Fr_inscricaoestadual = textBoxInscEstadual.Text;
                    AlteraFornecedor.Fr_fantasia = textBoxFantasia.Text;
                    AlteraFornecedor.Fr_endereco = textBoxEndereco.Text;
                    AlteraFornecedor.Fr_cidade = textBoxCidade.Text;
                    AlteraFornecedor.Fr_uf = textBoxUF.Text;
                    AlteraFornecedor.Fr_bairro = txtBairro.Text;
                    AlteraFornecedor.Fr_cep = maskedTextBoxCEP.Text;
                    AlteraFornecedor.Fr_contato = textBoxContato.Text;
                    AlteraFornecedor.Fr_telefone = maskedTextBoxTelefone.Text;
                    AlteraFornecedor.Fr_fax = textBoxFax.Text;
                    AlteraFornecedor.Fr_email = textBoxEmail.Text;
                    AlteraFornecedor.Fr_nomerepresentante = textBoxNomeRep.Text;
                    AlteraFornecedor.Fr_telefonerepresentante = maskedTextBoxTelRep.Text;
                    AlteraFornecedor.Fr_celularrepresentante = maskedTextBoxCelRep.Text;
                    AlteraFornecedor.Fr_observacoes = richTextBoxObservacoes.Text;

                    fachada.AlterarFornecedor(AlteraFornecedor);
                    MessageBox.Show("Fornecedor alterado com sucesso!");
                    LimparCampos();
                }


                 
            }

            catch (Exception ex)
            {
                 MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }



        }
   


    }
}
