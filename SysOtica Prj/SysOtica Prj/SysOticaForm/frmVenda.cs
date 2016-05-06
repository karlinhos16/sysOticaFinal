using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOtica;
using SysOtica.Conexao;
using SysOtica.Negocio.Fachada;

namespace SysOticaForm
{
    public partial class frmVenda : Form
    {
        Fachada fc = new Fachada();
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusForms.FormVenda = null;
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            CboCliente.DataSource = fc.listarCliente();
            CboCliente.ValueMember = "cl_id";
            CboCliente.DisplayMember = "cl_nome";
          
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
          
           




            
        }

        private void itemVendaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
