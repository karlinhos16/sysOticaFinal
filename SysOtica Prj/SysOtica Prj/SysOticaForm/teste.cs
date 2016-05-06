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
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysOticaDataSet.cliente);

        }
    }
}
