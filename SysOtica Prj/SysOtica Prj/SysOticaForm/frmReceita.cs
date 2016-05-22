using SysOticaForm.WebService;
using System;
using System.Collections;
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
    public partial class frmReceita : Form
    {

        private Service1Client webservice = new Service1Client();
        private List<Cliente> listaCli = new List<Cliente>();
        private Cliente cliente = new Cliente();
        private Receita dadosreceita = new Receita();

        public frmReceita()
        {
            InitializeComponent();

            carregaCliente();

        }



        public void LimparCampos()
        {

            txtLongeODesferico.Text = "";
            maskedTextData.Text = null;
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
                    receita.Rc_nomemedico = textNomeMedico.Text.Trim();
                    receita.Rc_observacoes = textObs.Text.Trim();
                    string data_validade = dateTimePickerValidade.Value.ToShortDateString();
                    receita.Rc_dtavencimento = Convert.ToDateTime(data_validade);
                    receita.Rc_data = DateTime.Parse(maskedTextData.Text);


                    if (DateTime.Parse(maskedTextData.Text) < DateTime.Today)
                    {
                        MessageBox.Show("A data de entrada não pode ser inferior a data atual", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }

                    if (DateTime.Parse(maskedTextData.Text) > Convert.ToDateTime(data_validade))
                    {
                        MessageBox.Show("A data de entrada não pode ser maior que a da validade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else if (DateTime.Parse(maskedTextData.Text) == Convert.ToDateTime(data_validade))
                    {
                        MessageBox.Show("Data de entrada e validade não podem ser as mesmas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }

                    if (cmbCliente.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecione um cliente!");
                    }
                    else
                    {
                        receita.Cliente.Cl_id = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                        webservice.InserirReceita(receita);
                        MessageBox.Show("Receita cadastra com sucesso.");
                        LimparCampos();

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        void carregaCliente()
        {
            listaCli = webservice.listarCliente().ToList<Cliente>();

            DataTable dt = new DataTable();

            dt.Columns.Add("cl_id");
            dt.Columns.Add("cl_nome");

            foreach (Cliente cli in listaCli)
            {

                DataRow row = dt.NewRow();
                row["cl_id"] = cli.Cl_id;
                row["cl_nome"] = cli.Cl_nome;
                dt.Rows.Add(row);

            }

            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "cl_nome";
            cmbCliente.ValueMember = "cl_id";

        }

        private void frmReceita_Load(object sender, EventArgs e)
        {
            maskedTextData.Text = DateTime.Now.ToShortDateString();
            maskedTextData.GotFocus += MaskedTextData_GotFocus;
        }

        private void MaskedTextData_GotFocus(object sender, EventArgs e)
        {
            maskedTextData.SelectAll();
        }

        private void maskedTextData_Click(object sender, EventArgs e)
        {
            maskedTextData.SelectAll();
        }
    }

}
