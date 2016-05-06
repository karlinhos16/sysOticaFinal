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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbLogin.Text.Equals("admin") && tbSenha.Text.Equals("admin"))
            {
                frmPrincipal Principal = new frmPrincipal();
                Principal.cadastroToolStripMenuItem.Enabled = true;
                Principal.financeiroToolStripMenuItem.Enabled = true;
                Principal.estoqueToolStripMenuItem.Enabled = true;
                Principal.movimentaçãoToolStripMenuItem.Enabled = true;
                Principal.relatóriosToolStripMenuItem.Enabled = true;
                Principal.sairToolStripMenuItem.Enabled = true;
                Principal.Show();
                
            }

            if (cbLogin.Text.Equals("vendedor") && tbSenha.Text.Equals("123456"))
            {
                frmPrincipal Principal = new frmPrincipal();
                Principal.cadastroToolStripMenuItem.Enabled = false;
                Principal.financeiroToolStripMenuItem.Enabled = false;
                Principal.estoqueToolStripMenuItem.Enabled = false;
                Principal.movimentaçãoToolStripMenuItem.Enabled = true;
                Principal.relatóriosToolStripMenuItem.Enabled = false;
                Principal.sairToolStripMenuItem.Enabled = true;
                Principal.Show();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
