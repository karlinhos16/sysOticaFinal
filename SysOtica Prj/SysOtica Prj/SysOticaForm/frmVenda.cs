using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using SysOticaForm.WebService;

namespace SysOticaForm
{
    public partial class frmVenda : Form
    {

        private Service1Client webservice = new Service1Client();
        private Cliente cliente = new Cliente();
        private Venda venda = new Venda();
        private List<ProdutoVenda> listaDeItens = new List<ProdutoVenda>();
        private List<Receita> receitavenda = new List<Receita>();



        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            CboCliente.DataSource = webservice.listarCliente();
            CboCliente.ValueMember = "cl_id";
            CboCliente.DisplayMember = "cl_nome";

            comboBoxProduto.DataSource = webservice.listarProduto();
            comboBoxProduto.ValueMember = "pr_id";
            comboBoxProduto.DisplayMember = "pr_descricao";

            
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            GroupBox.Visible = true;
            BtnNovaVenda.Enabled = false;

            if (CboCliente.SelectedItem.ToString() != null)
            {
                receitavenda = webservice.vendaReceita().ToList<Receita>();
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
           


            Produto p = (Produto)comboBoxProduto.SelectedItem;
            textBoxProdID.Text = p.Pr_id.ToString();
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
            #region GerandoXml

            int tamanhoDg = dataGridViewItens.Rows.Count;




            XmlDocument doc = new XmlDocument();

            XmlNode raiz = doc.CreateElement("VendaNFe");

            doc.AppendChild(raiz);

            XmlNode linha = doc.CreateElement("NotaFiscal");

            //dEmpresa
            XmlNode dEmpresa = doc.CreateElement("dEmpresa");
            XmlNode razaoSocial = doc.CreateElement("razaoSocial");
            XmlNode cnpj = doc.CreateElement("cnpj");
            XmlNode logradouro = doc.CreateElement("logradouro");

            //Produtos
            XmlNode idproNF = doc.CreateElement("idproNF");
            XmlNode descproNF = doc.CreateElement("descproNF");
            XmlNode vlrproNF = doc.CreateElement("vlrproNF");

            //Cliente
            XmlNode cliNF = doc.CreateElement("cliente");


            //Receita
            XmlNode rcID = doc.CreateElement("rcID");

            //Financeiro
            XmlNode vlrUnitario = doc.CreateElement("vlrUnitario");
            XmlNode desconto = doc.CreateElement("desconto");
            XmlNode vlrNota = doc.CreateElement("vlrNota");
            XmlNode formaPagamento = doc.CreateElement("formaPagamento");
            XmlNode dtaNota = doc.CreateElement("dtaNota");

            for (int i = 0; i < tamanhoDg; i++)
            {


                idproNF.InnerText = dataGridViewItens.Rows[i].Cells[0].Value.ToString();
                descproNF.InnerText = dataGridViewItens.Rows[i].Cells[1].Value.ToString();
                vlrproNF.InnerText = dataGridViewItens.Rows[i].Cells[2].Value.ToString();


            }

            razaoSocial.InnerText = "SysOtica LTDA.";
            cnpj.InnerText = "61.835.886/0001-88";
            logradouro.InnerText = "Avenida Imbiribeira, 900 - Recife - PE - CEP 55820-000";

            cliNF.InnerText = (cliente.Cl_nome);



            rcID.InnerText = txtIdReceita.Text;

            vlrUnitario.InnerText = ("R$" + textBox4.Text);
            desconto.InnerText = textBoxDes.Text;
            vlrNota.InnerText = ("R$" + textBoxValorPago.Text);
            formaPagamento.InnerText = comboBoxFP.SelectedText.ToString();
            dtaNota.InnerText = dateTimePickerAtual.Text;



            linha.AppendChild(dEmpresa);
            linha.AppendChild(razaoSocial);
            linha.AppendChild(cnpj);
            linha.AppendChild(logradouro);

            linha.AppendChild(cliNF);

            linha.AppendChild(idproNF);
            linha.AppendChild(descproNF);
            linha.AppendChild(vlrproNF);

            linha.AppendChild(rcID);

            linha.AppendChild(vlrUnitario);
            linha.AppendChild(desconto);
            linha.AppendChild(vlrNota);
            linha.AppendChild(formaPagamento);
            linha.AppendChild(dtaNota);

            doc.SelectSingleNode("/VendaNFe").AppendChild(linha);

            doc.Save(@"C:\Users\Leonardo Marques\Desktop\Apresentacao\SysOtica Prj\SysOtica Prj\VendasNFe.xml");
            //Caminho Leo : C:\Users\Leonardo Marques\Desktop\Projeto Final DSD Melo\sysOticaFinal\SysOtica Prj\SysOtica Prj\VendasNFe.xml
            MessageBox.Show("XML gerado com sucesso!");



            #endregion
            #region Finalizar a Venda
            Venda entVenda = new Venda();
            Cliente c = new Cliente();

            entVenda.Vn_desconto = Convert.ToDecimal(textBoxDes.Text);
            entVenda.Vn_valortotal = Convert.ToDecimal(textBoxValorPago.Text);
            entVenda.Vn_formapagamento = comboBoxFP.Text;
            entVenda.Vn_dtsaida = Convert.ToDateTime(dateTimePickerAtual.Text);
            entVenda.Cliente = cliente;
            entVenda.Receita.Rc_id = Convert.ToInt32(txtIdReceita.Text);
            entVenda.Listaitens = listaDeItens.ToArray<ProdutoVenda>();

            webservice.inserir(entVenda);

            MessageBox.Show("Venda realizada com sucesso!");
            #endregion
            #region Limpando os Campos
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
            #endregion
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
                //throw new Exception();
                MessageBox.Show("Erro ao selecionar receita" + ex.Message);
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

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValorPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
