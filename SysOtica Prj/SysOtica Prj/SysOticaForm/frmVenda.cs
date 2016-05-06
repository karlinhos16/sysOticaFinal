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
           
            this.clienteBindingSource.DataSource = fc.listarCliente();
            this.vendaBindingSource.DataSource = fc.listarVenda();
            this.produtoBindingSource.DataSource = fc.ListaProduto();

            this.vendaBindingSource.AddNew();
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
           




            Venda v = new Venda();
            
            v.CodigoCliente = Convert.ToInt32(CboCliente.SelectedValue);
            v.CodigoVenda = Convert.ToInt32(TxtVenda.Text);
            
            
           // fc.inserirVenda();
            
        }

        private void itemVendaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
