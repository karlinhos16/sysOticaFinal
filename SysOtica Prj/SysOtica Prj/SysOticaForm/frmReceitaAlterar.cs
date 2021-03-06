﻿using SysOticaForm.WebService;
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
    public partial class frmReceitaAlterar : Form
    {
        
        private Service1Client webservice = new Service1Client();
        private Receita alteraReceita = new Receita();



        public frmReceitaAlterar(Receita receita)
        {
            InitializeComponent();


            this.alteraReceita = receita;

            if (alteraReceita != null)

            {
                textIDReceita.Text = Convert.ToString(alteraReceita.Rc_id);
                txtLongeODesferico.Text = Convert.ToString(alteraReceita.Rc_lodesferico);
                maskedTextData.Text = Convert.ToString(alteraReceita.Rc_data);
                txtLongeOEesferico.Text = Convert.ToString(alteraReceita.Rc_loeesferico);
                txtPertoODesferico.Text = Convert.ToString(alteraReceita.Rc_podesferico);
                txtPertoOEesferico.Text = Convert.ToString(alteraReceita.Rc_poeesferico);
                txtLongeODcilindrico.Text = Convert.ToString(alteraReceita.Rc_lodcilindrico);
                txtLongeOEcilindrico.Text = Convert.ToString(alteraReceita.Rc_loecilindrico);
                txtPertoODcilindrico.Text = Convert.ToString(alteraReceita.Rc_podcilindrico);
                txtPertoOEcilindrico.Text = Convert.ToString(alteraReceita.Rc_poecilindrico);
                txtLongeODeixo.Text = Convert.ToString(alteraReceita.Rc_lodeixo);
                txtLongeOEeixo.Text = Convert.ToString(alteraReceita.Rc_loeeixo);
                txtPertoODeixo.Text = Convert.ToString(alteraReceita.Rc_podeixo);
                txtPertoOEeixo.Text = Convert.ToString(alteraReceita.Rc_poeeixo);
                txtLongeODaltura.Text = Convert.ToString(alteraReceita.Rc_lodaltura);
                txtLongeOEaltura.Text = Convert.ToString(alteraReceita.Rc_loealtura);
                txtPertoODaltura.Text = Convert.ToString(alteraReceita.Rc_podaltura);
                txtPertoOEaltura.Text = Convert.ToString(alteraReceita.Rc_poealtura);
                txtLongeODdnp.Text = Convert.ToString(alteraReceita.Rc_loddnp);
                txtLongeOEdnp.Text = Convert.ToString(alteraReceita.Rc_loednp);
                txtPertoODdnp.Text = Convert.ToString(alteraReceita.Rc_poddnp);
                txtPertoOEdnp.Text = Convert.ToString(alteraReceita.Rc_poednp);            
                textNomeMedico.Text = alteraReceita.Rc_nomemedico;
                textObs.Text = alteraReceita.Rc_observacoes;
                dateTimePickerValidade.Text = Convert.ToString(alteraReceita.Rc_dtavencimento);

            }



        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                    receita.Rc_nomemedico = textNomeMedico.Text.Trim();
                    receita.Rc_observacoes = textObs.Text.Trim();
                    string data = dateTimePickerValidade.Value.ToShortDateString();
                    receita.Rc_dtavencimento = Convert.ToDateTime(data);

                }
                if (alteraReceita == null)
                {
                    webservice.AlterarReceita(receita);
                    MessageBox.Show("Receita alterado com sucesso!");
                    LimparCampos();
                }

                else
                {
                    alteraReceita.Rc_lodesferico = Convert.ToDecimal(txtLongeODesferico.Text);
                    alteraReceita.Rc_loeesferico = Convert.ToDecimal(txtLongeOEesferico.Text);
                    alteraReceita.Rc_podesferico = Convert.ToDecimal(txtPertoODesferico.Text);
                    alteraReceita.Rc_poeesferico = Convert.ToDecimal(txtPertoOEesferico.Text);
                    alteraReceita.Rc_lodcilindrico = Convert.ToDecimal(txtLongeODcilindrico.Text);
                    alteraReceita.Rc_loecilindrico = Convert.ToDecimal(txtLongeOEcilindrico.Text);
                    alteraReceita.Rc_podcilindrico = Convert.ToDecimal(txtPertoODcilindrico.Text);
                    alteraReceita.Rc_poecilindrico = Convert.ToDecimal(txtPertoOEcilindrico.Text);
                    alteraReceita.Rc_lodeixo = Convert.ToDecimal(txtLongeODeixo.Text);
                    alteraReceita.Rc_loeeixo = Convert.ToDecimal(txtLongeOEeixo.Text);
                    alteraReceita.Rc_podeixo = Convert.ToDecimal(txtPertoODeixo.Text);
                    alteraReceita.Rc_poeeixo = Convert.ToDecimal(txtPertoOEeixo.Text);
                    alteraReceita.Rc_lodaltura = Convert.ToDecimal(txtLongeODaltura.Text);
                    alteraReceita.Rc_loealtura = Convert.ToDecimal(txtLongeOEaltura.Text);
                    alteraReceita.Rc_podaltura = Convert.ToDecimal(txtPertoODaltura.Text);
                    alteraReceita.Rc_poealtura = Convert.ToDecimal(txtPertoOEaltura.Text);
                    alteraReceita.Rc_loddnp = Convert.ToDecimal(txtLongeODdnp.Text);
                    alteraReceita.Rc_loednp = Convert.ToDecimal(txtLongeOEdnp.Text);
                    alteraReceita.Rc_poddnp = Convert.ToDecimal(txtPertoODdnp.Text);
                    alteraReceita.Rc_poednp = Convert.ToDecimal(txtPertoOEdnp.Text);
                    alteraReceita.Rc_data = DateTime.Parse(maskedTextData.Text);                  
                    alteraReceita.Rc_nomemedico = textNomeMedico.Text.Trim();
                    alteraReceita.Rc_observacoes = textObs.Text.Trim();
                    string data_validade = dateTimePickerValidade.Value.ToShortDateString();
                    alteraReceita.Rc_dtavencimento = Convert.ToDateTime(data_validade);

            

                    if (Convert.ToDateTime(data_validade) <  DateTime.Parse(maskedTextData.Text))
                    {
                        MessageBox.Show("A data de validade não pode ser menor do que a data de entrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else if (DateTime.Parse(maskedTextData.Text) == Convert.ToDateTime(data_validade))

                    {
                        MessageBox.Show("Data de entrada e validade não podem ser as mesmas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }


                    webservice.AlterarReceita(alteraReceita);
                    MessageBox.Show("Receita alterada com sucesso! ");
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private void frmReceitaAlterar_Load(object sender, EventArgs e)
        {
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
