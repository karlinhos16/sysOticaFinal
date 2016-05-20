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
        List<ProdutoVenda> listaDeItens = new List<ProdutoVenda>();
        List<Receita> receitavenda = new List<Receita>();
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

            
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            GroupBox.Visible = true;
            BtnNovaVenda.Enabled = false;

            if (CboCliente.SelectedItem.ToString() != null)
            {
                receitavenda = fc.vendaReceita();
                dataGridRec.DataSource = null;
                dataGridRec.AutoGenerateColumns = false;

                foreach (var receitas in receitavenda)
                {

                    if (receitas.Rc_id.ToString() != null && receitas.Cliente.Cl_id.ToString() == (textBoxPegarNome.Text.Trim().ToString()))
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

                        CboCliente.Enabled = false;
                    }

                }
                vencimentoReceita();
            }





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
            entVenda.Receita.Rc_id = Convert.ToInt32(txtIdReceita.Text);
            entVenda.Listaitens = listaDeItens;

            fc.inserir(entVenda);

            MessageBox.Show("Venda realizada com sucesso!");

            //Limpando campos

            dataGridViewItens.Rows.Clear();
            dataGridViewItens.Refresh();
            textBoxQtd.Clear();
            textBoxDes.Clear();
            textBoxProdID.Clear();
            textBoxValor.Clear();
            textBox4.Clear();
            textBoxValorPago.Clear();

            comboBoxProduto.Enabled = true;
            buttonNovoItem.Enabled = true;
            textBoxQtd.Enabled = true;
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (CboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente!");
            }
            else {
                Cliente c = (Cliente)CboCliente.SelectedItem;
                cliente = c;
                textBoxPegarNome.Text = CboCliente.SelectedValue.ToString();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente apagar este item da venda?","Apagar Registro",MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                dataGridViewItens.Rows.Remove(dataGridViewItens.CurrentRow);
            }
          
        }

        private void textBoxQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBoxDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente cancelar a compra?", "Cancelar", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2,0,false) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void dataGridRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow linhaAtual = dataGridRec.CurrentRow;
                if (linhaAtual.Index >= -1)
                {
                    if (linhaAtual != null)
                    {

                        string coluna = dataGridRec.Rows[e.RowIndex].Cells[4].Value.ToString();

                        if (Convert.ToDateTime(coluna) > DateTime.Today)
                        {

                            MessageBox.Show("Esta receita não se encontra na data de validade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;

                        }
                        else if (dataGridRec.CurrentCell.RowIndex >= -1)
                        {

                            txtIdReceita.Text = dataGridRec.Rows[e.RowIndex].Cells[0].Value.ToString();
                            MessageBox.Show("Receita selecionada com sucesso!");

                        }
                    }

                }

            }
            catch (Exception ex)

            {
                throw new Exception("Erro ao selecionar receita" + ex.Message);

            }
        }
        void vencimentoReceita()
        {
            if (dataGridRec != null)
            {
                //dataGridRec.AutoGenerateColumns = false;
                for (int i = 0; i < dataGridRec.Rows.Count; i++)
                {
                    string coluna1 = dataGridRec.Rows[i].Cells[4].Value.ToString();

                    if (Convert.ToDateTime(coluna1) > DateTime.Today && Convert.ToDateTime(coluna1) != null)
                    {

                        dataGridRec.Rows[i].DefaultCellStyle.BackColor = Color.Orange;

                    }

                    else
                    {
                        dataGridRec.Rows[i].DefaultCellStyle.BackColor = Color.White;


                    }

                }

            }

        }


    }
}
