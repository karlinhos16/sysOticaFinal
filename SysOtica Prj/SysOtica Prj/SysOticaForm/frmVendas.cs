using SysOticaForm.WebService;
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
        private Service1Client webservice = new WebService.Service1Client();
        private WebService.Cliente cliente = new WebService.Cliente();
        private WebService.Produto produto = new WebService.Produto();
        private WebService.Venda venda = new WebService.Venda();
        private WebService.ProdutoVenda produtovenda = new WebService.ProdutoVenda();
        private List<WebService.ProdutoVenda> listaDeItens = new List<WebService.ProdutoVenda>();
        private List<WebService.Receita> receitavenda = new List<WebService.Receita>();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            comboBoxCliente.DataSource = webservice.listarCliente();
            comboBoxCliente.ValueMember = "cl_id";
            comboBoxCliente.DisplayMember = "cl_nome";

            comboBoxProduto.DataSource = webservice.listarProduto();
            comboBoxProduto.ValueMember = "pr_id";
            comboBoxProduto.DisplayMember = "pr_descricao";

            try
            {
                if (comboBoxCliente.SelectedItem.ToString() != null)
                {
                    receitavenda = webservice.vendaReceita().ToList<WebService.Receita>();
                    dataGridRec.DataSource = null;
                    dataGridRec.AutoGenerateColumns = false;

                    foreach (var receitas in receitavenda)
                    {

                        if (receitas.Rc_id.ToString() != null && receitas.Cliente.Cl_id.ToString() == (textBox1.Text.Trim().ToString()))
                        {

                            if (dataGridRec.RowCount >= -1)
                            {


                                dataGridRec.Rows.Add((receitas.Rc_id).ToString(),
                                receitas.Rc_nomemedico.ToString(),
                                receitas.Rc_observacoes.ToString(),
                                receitas.Rc_data.ToShortDateString(),
                                receitas.Rc_dtavencimento.ToShortDateString());
                               

                            }
                            else
                            {
                                dataGridRec.Rows.Clear();

                            }
                        }

                    }
                     vencimentoReceita();
                }
            }
            catch
            {
                MessageBox.Show("Não existe receita cadastrada para esse cliente", "Receita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       public void vencimentoReceita()
        {

            try
            {
                if (dataGridRec != null)
                {
                    //dataGridRec.AutoGenerateColumns = false;
                    for (int i = 0; i < dataGridRec.Rows.Count; i++)
                    {
                        string coluna1 = dataGridRec.Rows[i].Cells[4].Value.ToString();

                        if (Convert.ToDateTime(coluna1) < DateTime.Today && Convert.ToDateTime(coluna1) != null)
                        {

                            dataGridRec.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                        }

                        else
                        {
                            dataGridRec.Rows[i].DefaultCellStyle.BackColor = Color.Green;


                        }

                    }

                }
            }
            catch
            {
                MessageBox.Show("Erro na verificação do vencimento da Receita!", "Receita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um cliente!");
                }
                else
                {
                    Cliente c = (WebService.Cliente)comboBoxCliente.SelectedItem;
                    cliente = c;
                    textBox1.Text = comboBoxCliente.SelectedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Cliente não selecionado! Por favor, selecione um cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProduto.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um produto!");
                }
                else
                {
                    Produto p = (WebService.Produto)comboBoxProduto.SelectedItem;
                    produto = p;
                    textBoxProdID.Text = comboBoxProduto.SelectedValue.ToString();
                    textBoxValor.Text = Convert.ToString(p.Pr_valor);
                    textBoxPegarProduto.Text = Convert.ToString(p.Pr_descricao);
                }
            }
            catch
            {
                MessageBox.Show("Produto não selecionado! Por favor, selecione um produto.", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void buttonNovoItem_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxQtdMult.Text = (Convert.ToDecimal(textBoxQtd.Text) * Convert.ToDecimal(textBoxValor.Text)).ToString();
                addItem(textBoxProdID.Text, textBoxPegarProduto.Text, textBoxQtd.Text, textBoxValor.Text, textBoxQtdMult.Text);

                Produto p = new WebService.Produto();
                p.Pr_id = Int32.Parse(textBoxProdID.Text);
                ProdutoVenda pv = new WebService.ProdutoVenda();

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
            catch
            {

            }
        }
        private void addItem(string text1, string text2, string text3, string text4, string text5)
        {

            String[] row = { text1, text2, text3, text4, text5 };

            dataGridViewItens.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente concluir a selação de produtos?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
                {
                    
                    textBoxValorPago.Text = (Convert.ToDecimal(textBox4.Text) - Convert.ToDecimal(textBoxDes.Text)).ToString();
                    comboBoxCliente.Enabled = false;
                    comboBoxProduto.Enabled = false;
                    buttonNovoItem.Enabled = false;
                    textBoxQtd.Enabled = false;
                    buttonExcluir.Enabled = false;
                }


            }
            catch
            {
                MessageBox.Show("Continue a selecionar os produtos da venda do Cliente!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
