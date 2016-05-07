using SysOtica;
using SysOtica.Conexao;
using SysOtica.Negocio;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Fachada;
using System;
using System.Collections;
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

       public List<Cliente> listaCli;
       public List<Receita> listaReceita;
       Receita selecionaReceita;
        ReceitaDados dadosreceita = new ReceitaDados();
    

        public frmReceita()
        {
            InitializeComponent();
           
            carregaCliente();

            carregaHistorico();

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

                    //if (listBoxDatas.SelectedIndex >= -1)
                    //{
                    //    listBoxDatas.Items.Add(Convert.ToString(maskedTextData.Text));

                    //   receita.Rc_historico = listBoxDatas.ValueMember = maskedTextData.Text;
                    //}  

                    Cliente cli = new  Cliente();
                    cli.Cl_id = Convert.ToInt32(cmbCliente.SelectedValue.ToString());

                    Fachada fachada = new Fachada();
                    fachada.InserirReceita(receita, cli);
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



        void carregaCliente()
        {
            ClienteDados dados = new ClienteDados();
            listaCli = dados.listarCliente();

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



        void carregaHistorico()
        {
           
            List<Receita> lista;
            lista = dadosreceita.listaReceita();

            DataTable data = new DataTable();

            data.Columns.Add("rc_historico");

            foreach (Receita receita in lista)
            {
                DataRow row1 = data.NewRow();
                row1["rc_historico"] = receita.Rc_historico;
                data.Rows.Add(row1);

            }

            listBoxDatas.DataSource = data;
            listBoxDatas.DisplayMember = "rc_historico";

      

        }

        private void listBoxDatas_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxDatas != null)
            {
                if (listBoxDatas.SelectedIndex >= 0)
                {
                   
                
                    if (selecionaReceita == null)
                    {

                        maskedTextData.Text = selecionaReceita.Rc_data.ToString();
                        txtLongeODesferico.Text = selecionaReceita.Rc_lodesferico.ToString();
                        txtLongeOEesferico.Text = selecionaReceita.Rc_lodesferico.ToString();
                        txtPertoODesferico.Text = selecionaReceita.Rc_podesferico.ToString();
                        txtPertoOEesferico.Text = selecionaReceita.Rc_poeesferico.ToString();
                        txtLongeODcilindrico.Text = selecionaReceita.Rc_lodcilindrico.ToString();
                        txtLongeOEcilindrico.Text = selecionaReceita.Rc_loecilindrico.ToString();
                        txtPertoODcilindrico.Text = selecionaReceita.Rc_podcilindrico.ToString();
                        txtPertoOEcilindrico.Text = selecionaReceita.Rc_poecilindrico.ToString();
                        txtLongeODeixo.Text = selecionaReceita.Rc_lodeixo.ToString();
                        txtLongeOEeixo.Text = selecionaReceita.Rc_loeeixo.ToString();
                        txtPertoODeixo.Text = selecionaReceita.Rc_podeixo.ToString();
                        txtPertoOEeixo.Text = selecionaReceita.Rc_poeeixo.ToString();
                        txtLongeODaltura.Text = selecionaReceita.Rc_lodaltura.ToString();
                        txtLongeOEaltura.Text = selecionaReceita.Rc_loealtura.ToString();
                        txtPertoODaltura.Text = selecionaReceita.Rc_podaltura.ToString();
                        txtPertoOEaltura.Text = selecionaReceita.Rc_poealtura.ToString();
                        txtLongeODdnp.Text = selecionaReceita.Rc_loddnp.ToString();
                        txtLongeOEdnp.Text = selecionaReceita.Rc_loednp.ToString();
                        txtPertoODdnp.Text = selecionaReceita.Rc_poddnp.ToString();
                        txtPertoOEdnp.Text = selecionaReceita.Rc_poednp.ToString();
                      //textAdicao.Text = selecionaReceita.Rc_adicao.ToString();
                        textNomeMedico.Text = selecionaReceita.Rc_nomemedico;
                        textObs.Text = selecionaReceita.Rc_observacoes;
                        dateTimePickerValidade.Text = selecionaReceita.Rc_dtavalidade.ToString();
                        //cmbCliente.Text = cliente.Cl_nome.ToString();


                    }

                    btnSalvar.Enabled = false;

                }
            }
        }
    }

}
