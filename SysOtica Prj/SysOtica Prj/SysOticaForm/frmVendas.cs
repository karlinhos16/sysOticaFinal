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
    public partial class frmVendas : Form
    {
        Fachada fachada = new Fachada();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonBuscar.Text != "")
                {

                    dataGridView1.DataSource = null;
                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.DataSource = fachada.obterCliente(buttonBuscar.Text.Trim());

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha na busca" + ex.Message);

            }
        }
     }
  }

