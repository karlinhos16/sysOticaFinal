using SysOtica;
using SysOtica.Negocio;
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
    public partial class frmReceita : Form
    {
        public frmReceita()
        {
            InitializeComponent();
        }

        

        public void LimparCampos()
        {
            txtLongeODesferico.Text = "";
            DateTime.Parse(maskedTextData.Text).Equals("");
            txtLongeOEesferico.Text = "";
            txtPertoODesferico.Text = "";
            txtPertoOEesferico.Text = "";
            txtLongeODcilindrico.Text = "";
            txtLongeOEcilindrico.Text = "";
            txtPertoODcilindrico.Text = "";
            txtPertoOEcilindrico.Text = "";
            txtLongeODeixo.Text = "";
            txtLongeOEeixo.Text = "";
            txtPertoODeixo.Text = "";
            txtPertoOEeixo.Text = "";
            txtLongeODaltura.Text = "";
            txtLongeOEaltura.Text = "";
            txtPertoODaltura.Text = "";
            txtPertoOEaltura.Text = "";
            txtLongeODdnp.Text = "";
            txtLongeOEdnp.Text = "";
            txtPertoODdnp.Text = "";
            txtPertoOEdnp.Text = "";
            textAdicao.Text = "";
            textNomeMedico.Text = "";
            textObs.Text = "";
            
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {

                Receita receita = new Receita();
                {
                    receita.Rc_lodesferico = Convert.ToDecimal(txtLongeODesferico.Text);
                    receita.Rc_loeesferico = Convert.ToDecimal(txtLongeOEesferico.Text);
                    receita.Rc_podesferico = Convert.ToDecimal(txtPertoODesferico.Text);
                    receita.Rc_poeesferico = Convert.ToDecimal(txtPertoOEesferico.Text);
                    receita.Rc_lodcilindrico = Convert.ToDecimal(txtLongeODcilindrico.Text);
                    receita.Rc_loecilindrico = Convert.ToDecimal(txtLongeOEcilindrico.Text);
                    receita.Rc_podcilindrico = Convert.ToDecimal(txtPertoODcilindrico.Text);
                    receita.Rc_poecilindrico = Convert.ToDecimal(txtPertoOEcilindrico.Text);
                    receita.Rc_lodeixo = Convert.ToDecimal(txtLongeODeixo.Text);
                    receita.Rc_loeeixo = Convert.ToDecimal(txtLongeOEeixo.Text);
                    receita.Rc_podeixo = Convert.ToDecimal(txtPertoODeixo.Text);
                    receita.Rc_poeeixo = Convert.ToDecimal(txtPertoOEeixo.Text);
                    receita.Rc_lodaltura = Convert.ToDecimal(txtLongeODaltura.Text);
                    receita.Rc_loealtura = Convert.ToDecimal(txtLongeOEaltura.Text);
                    receita.Rc_podaltura = Convert.ToDecimal(txtPertoODaltura.Text);
                    receita.Rc_poealtura = Convert.ToDecimal(txtPertoOEaltura.Text);
                    receita.Rc_loddnp = Convert.ToDecimal(txtLongeODdnp.Text);
                    receita.Rc_loednp = Convert.ToDecimal(txtLongeOEdnp.Text);
                    receita.Rc_poddnp = Convert.ToDecimal(txtPertoODdnp.Text);
                    receita.Rc_poednp = Convert.ToDecimal(txtPertoOEdnp.Text);
                    receita.Rc_data = DateTime.Parse(maskedTextData.Text);
                   //Receita.Rc_adicao = Convert.ToDecimal(textAdicao.Text);
                    receita.Rc_nomemedico = textNomeMedico.Text.Trim();
                    receita.Rc_observacoes = textObs.Text.Trim();

                    string data = dateTimePickerValidade.Value.ToShortDateString();
                    receita.Rc_dtavalidade = Convert.ToDateTime(data);

                    Fachada fachada = new Fachada();
                    fachada.InserirReceita(receita);
                    MessageBox.Show("Receita cadastra com sucesso.");
                    LimparCampos();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco" + ex.Message);
            }


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }

}
