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
    public partial class formClienteAlterar : Form
    {
        Cliente alteraCliente;
        Fachada fachada = new Fachada();

        public formClienteAlterar(Cliente c)
        {
            InitializeComponent();

            this.alteraCliente = c;

            if(alteraCliente != null)
            {
                textBoxID.Text = Convert.ToString(alteraCliente.Cl_id);
                textBoxNome.Text = alteraCliente.Cl_nome;
                dateTimePicker1.Text = Convert.ToString(alteraCliente.Cl_datanascimento);
                textBoxCPF.Text = alteraCliente.Cl_cpf;
                textBoxRg.Text = alteraCliente.Cl_rg;
                maskedTextBoxTelefone.Text = alteraCliente.Cl_telefone;
                maskedTextBoxCelular.Text = alteraCliente.Cl_celular;
                maskedTextBoxTelefone2.Text = alteraCliente.Cl_telefone2;
                maskedTextBoxCep.Text = alteraCliente.Cl_cep;
                textBoxEndereco.Text = alteraCliente.Cl_endereco;
                textBoxNumero.Text = alteraCliente.Cl_numero;
                textBoxBairro.Text = alteraCliente.Cl_bairro;
                textBoxCidade.Text = alteraCliente.Cl_cidade;
                textBoxUF.Text = alteraCliente.Cl_uf;
                textBoxEmail.Text = alteraCliente.Cl_email;
                textBoxNomepai.Text = alteraCliente.Cl_nomepai;
                textBoxNomemae.Text = alteraCliente.Cl_nomemae;
                textBoxProfissao.Text = alteraCliente.Cl_profissao;
                richTextBoxObservacoes.Text = alteraCliente.Cl_observacoes;
              
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();

                {
                    c.Cl_id = Convert.ToInt32(textBoxID.Text);
                    c.Cl_nome = textBoxNome.Text;
                    c.Cl_datanascimento = Convert.ToDateTime(dateTimePicker1.Text);
                    c.Cl_cpf = textBoxCPF.Text;
                    c.Cl_rg = textBoxRg.Text;
                    c.Cl_telefone = maskedTextBoxTelefone.Text;
                    c.Cl_celular = maskedTextBoxCelular.Text;
                    c.Cl_telefone = maskedTextBoxTelefone2.Text;
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
                
                }
                if (alteraCliente == null)
                {
                    fachada.alterarCliente(c);
                    MessageBox.Show("Cliente alterado com sucesso!");
                    limparCampos();
                }
                else
                {
                    alteraCliente.Cl_id = Convert.ToInt32(textBoxID.Text);
                    alteraCliente.Cl_nome = textBoxNome.Text;
                    alteraCliente.Cl_datanascimento = DateTime.Parse(dateTimePicker1.Text);
                    alteraCliente.Cl_cpf = textBoxCPF.Text;
                    alteraCliente.Cl_rg = textBoxRg.Text;
                    alteraCliente.Cl_telefone = maskedTextBoxTelefone.Text;
                    alteraCliente.Cl_celular = maskedTextBoxCelular.Text;
                    alteraCliente.Cl_telefone2 = maskedTextBoxTelefone2.Text;
                    alteraCliente.Cl_cep = maskedTextBoxCep.Text;
                    alteraCliente.Cl_endereco = textBoxEndereco.Text;
                    alteraCliente.Cl_numero = textBoxNumero.Text;
                    alteraCliente.Cl_bairro = textBoxBairro.Text;
                    alteraCliente.Cl_cidade = textBoxCidade.Text;
                    alteraCliente.Cl_uf = textBoxUF.Text;
                    alteraCliente.Cl_email = textBoxEmail.Text;
                    alteraCliente.Cl_nomepai = textBoxNomepai.Text;
                    alteraCliente.Cl_nomemae = textBoxNomemae.Text;
                    alteraCliente.Cl_profissao = textBoxProfissao.Text;
                    alteraCliente.Cl_observacoes = richTextBoxObservacoes.Text;

                    fachada.alterarCliente(alteraCliente);
                    MessageBox.Show("Cliente alterado com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                    limparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }
        }

        private void limparCampos()
        {
            textBoxID.Text = "";
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
            textBoxUF.Text = "";
            textBoxEmail.Text = "";
            textBoxNomepai.Text = "";
            textBoxNomemae.Text = "";
            textBoxProfissao.Text = "";
            richTextBoxObservacoes.Text = "";
        }
    }
}
