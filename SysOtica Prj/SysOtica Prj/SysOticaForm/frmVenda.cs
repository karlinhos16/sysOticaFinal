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
        Receita receita;
        List<ProdutoVenda> listaDeItens = new List<ProdutoVenda>();
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

            comboBoxProduto.DataSource = fc.listarProduto();
            comboBoxProduto.ValueMember = "pr_id";
            comboBoxProduto.DisplayMember = "pr_descricao";

            comboBoxReceita.DataSource = fc.listaReceitaReceita();
            comboBoxReceita.ValueMember = "rc_id";
            comboBoxReceita.DisplayMember = "rc_dtavencimento";
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
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

            Produto p = new Produto();
            p.Pr_id = Int32.Parse(textBoxProdID.Text);
            ProdutoVenda pv = new ProdutoVenda();

            pv.Produto = p;
            pv.Pv_qtd = Convert.ToInt32(textBoxQtd.Text);
            pv.Pv_preco = Convert.ToDecimal(textBoxValor.Text);

            listaDeItens.Add(pv);

            decimal valorTotal = 0;

            foreach (DataGridViewRow col in dataGridViewItens.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[4].Value);
            }

            textBox4.Text = Convert.ToString(valorTotal);
        }

        private void addItem(string text1, string text2, string text3, string text4, string text5)
        {

            String[] row = { text1, text2, text3, text4, text5 };

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
            Venda entVenda = new Venda();
            Cliente c = new Cliente();

            entVenda.Vn_desconto = Convert.ToDecimal(textBoxDes.Text);
            entVenda.Vn_valortotal = Convert.ToDecimal(textBoxValorPago.Text);
            entVenda.Vn_formapagamento = comboBoxFP.Text;
            entVenda.Vn_dtsaida = Convert.ToDateTime(dateTimePickerAtual.Text);
            entVenda.Cliente = cliente;
            entVenda.Receita = receita;
            entVenda.Listaitens = listaDeItens;

            fc.inserir(entVenda);

            MessageBox.Show("Venda realizada com sucesso!");
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)CboCliente.SelectedItem;
            cliente = c;
            textBoxPegarNome.Text = CboCliente.SelectedValue.ToString();
        }

        private void comboBoxReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            Receita r = (Receita)comboBoxReceita.SelectedItem;
            receita = r;
            textBoxPegarReceita.Text = comboBoxReceita.SelectedValue.ToString();
        }
    }
}
