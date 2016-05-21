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
    public partial class frmVendas : Form
    {
        Venda venda;
        Cliente cliente;
        List<ProdutoVenda> listaDeItens = new List<ProdutoVenda>();
        List<Receita> receitavenda = new List<Receita>();
        Fachada fc = new Fachada();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            comboBoxCliente.DataSource = fc.listarCliente();
            comboBoxCliente.ValueMember = "cl_id";
            comboBoxCliente.DisplayMember = "cl_nome";

            comboBoxProduto.DataSource = fc.listarProduto();
            comboBoxProduto.ValueMember = "pr_id";
            comboBoxProduto.DisplayMember = "pr_descricao";
        }
    }
  }

