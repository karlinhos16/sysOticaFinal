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
using SysOtica.Negocio.Classes_Basicas;
using System.Data.SqlClient;

namespace SysOticaForm
{
    public partial class frmVenda : Form
    {
        Venda venda;
        Cliente cliente;
        Fachada fc = new Fachada();
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            CboCliente.DataSource = fc.listarCliente();
            CboCliente.ValueMember = "cl_id";
            CboCliente.DisplayMember = "cl_nome";

            comboBoxProduto.DataSource = fc.ListaProduto();
            comboBoxProduto.ValueMember = "pr_id";
            comboBoxProduto.DisplayMember = "pr_descricao";
        }

        private void BtnNovaVenda_Click_1(object sender, EventArgs e)
        {
            GroupBox.Visible = true;
            BtnNovaVenda.Enabled = false;
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxProdID.Text = comboBoxProduto.SelectedValue.ToString();
            

            Produto p = (Produto)comboBoxProduto.SelectedItem;
            textBoxValor.Text = Convert.ToString(p.Pr_valor);
            textBoxPegarProduto.Text = Convert.ToString(p.Pr_descricao);
        }

        private void buttonNovoItem_Click(object sender, EventArgs e)
        {
            textBoxQtdMult.Text = (Convert.ToDecimal(textBoxQtd.Text) * Convert.ToDecimal(textBoxValor.Text)).ToString();
            addItem(textBoxProdID.Text, textBoxPegarProduto.Text, textBoxQtd.Text, textBoxValor.Text, textBoxQtdMult.Text);

            decimal valorTotal = 0;

            foreach(DataGridViewRow col in dataGridViewItens.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[4].Value);
            }

            textBox4.Text = Convert.ToString(valorTotal);
        }

        private void addItem(string text1, string text2, string text3, string text4, string text5)
        {
           
            String[] row = { text1, text2, text3, text4, text5};

            dataGridViewItens.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxProduto.Enabled = false;
            buttonNovoItem.Enabled = false;
            textBoxQtd.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxValorPago.Text = (Convert.ToDecimal(textBox4.Text) - Convert.ToDecimal(textBoxDes.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewItens.Rows.Count - 1; i++)
            {
               
                Venda v = new Venda();

                v.Vn_desconto = Convert.ToDecimal(textBoxDes.Text);
                v.Vn_formapagamento = comboBoxFP.Text;
                v.Vn_valor = Convert.ToDecimal(dataGridViewItens.Rows[i].Cells[3].Value);
                v.Vn_valortotal = Convert.ToDecimal(textBoxValorPago.Text);
                v.Vn_dtsaida = Convert.ToDateTime(dateTimePickerAtual.Text);
                v.Cliente = this.cliente;
                fc.inserir(v);      
            }
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)CboCliente.SelectedItem;
            textBoxPegarNome.Text = CboCliente.SelectedValue.ToString();
        }
    }
}
