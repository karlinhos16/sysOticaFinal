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

        List<ProdutoVenda> listaprodutovenda = new List<ProdutoVenda>();

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

            foreach (DataGridViewRow row in dataGridViewItens.Rows)
            {
                ProdutoVenda item = new ProdutoVenda();

                row.Cells[0].Value = item.Produto;
                row.Cells[1].Value = item.Produto;
                row.Cells[3].Value = item.Produto;


                //item.Produto.Pr_id = Convert.ToInt32(row.Cells[0].Value);
                //item.Produto.Pr_descricao = Convert.ToString(row.Cells[1].Value);
                //item.Produto.Pr_valor = Convert.ToDecimal(row.Cells[3].Value);

                listaprodutovenda.Add(item);
            }

            //foreach (DataGridViewRow col in dataGridViewItens.Rows)
            //{
                
            //    ProdutoVenda item = new ProdutoVenda();
            //    Produto produto = new Produto();


            //    item.Produto.Pr_id = Convert.ToInt32(col.Cells[0].Value);
            //    item.Produto.Pr_descricao = Convert.ToString(col.Cells[1].Value);
            //    item.Produto.Pr_valor = Convert.ToDecimal(col.Cells[3].Value);
              
            //    listaprodutovenda.Add(item);

            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxValorPago.Text = (Convert.ToDecimal(textBox4.Text) - Convert.ToDecimal(textBoxDes.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listaprodutovenda.Count > 0)
            {
                Venda entVenda = new Venda();

                foreach (ProdutoVenda pv in listaprodutovenda)
                {
                    entVenda.Listaitens.Add(pv);
                }
                entVenda.Cliente.Cl_id = Convert.ToInt32(textBoxPegarNome.Text);
                entVenda.Vn_desconto = Convert.ToDecimal(textBoxDes.Text);
                entVenda.Vn_valor = Convert.ToDecimal(textBoxValor.Text);
                entVenda.Vn_valortotal = Convert.ToDecimal(textBoxValorPago.Text);
                entVenda.Vn_formapagamento = comboBoxFP.Text;
                entVenda.Vn_dtsaida = Convert.ToDateTime(dateTimePickerAtual.Text);

                fc.inserir(entVenda);
                MessageBox.Show("Venda realizada com sucesso!");
            }
            else
                MessageBox.Show("Não existe itens na venda!");
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)CboCliente.SelectedItem;
            textBoxPegarNome.Text = CboCliente.SelectedValue.ToString();
        }

        private void comboBoxFP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
