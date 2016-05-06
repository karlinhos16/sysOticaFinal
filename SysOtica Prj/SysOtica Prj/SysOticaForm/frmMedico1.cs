using System;
using SysOtica.Negócio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOtica;
using SysOtica.Conexão;

namespace SysOticaForm
{
    public partial class frmMedico1 : Form
    {
        public frmMedico1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            try
            {
                Medico medico = new Medico();
                {
                    medico.Md_nome = textNome.Text.Trim();
                    medico.Md_crm = textCrm.Text.Trim();
                    medico.Md_telefone = maskedTextBox1.Text;
                    medico.Md_email = textEmail.Text.Trim();
                }

                Fachada fachadaMedico = new Fachada();
                fachadaMedico.CadastraMedico(medico);
                MessageBox.Show("Médico cadastrado com sucesso");
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar "  + ex.Message);
            }

        }

        public void LimparCampos()
        {

            textNome.Text = "";
            textCrm.Text = "";
            maskedTextBox1.Text = "";
            textEmail.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

      
    }


}
