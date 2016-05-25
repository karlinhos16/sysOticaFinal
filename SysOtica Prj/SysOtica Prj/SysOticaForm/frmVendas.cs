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
using System.Xml;

namespace SysOticaForm
{
    public partial class frmVendas : Form
    {
        private Service1Client webservice = new WebService.Service1Client();
        private WebService.Cliente cliente = new WebService.Cliente();
        private WebService.Produto produto = new WebService.Produto();
        private WebService.Venda venda = new WebService.Venda();
        private WebService.ProdutoVenda produtovenda = new WebService.ProdutoVenda();
        private WebService.Receita receita = new WebService.Receita();

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
                    groupBoxVenda.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Continue a selecionar os produtos da venda do Cliente!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            #region Finalizar a Venda

            if (MessageBox.Show("Deseja realizar a venda?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                Venda entVenda = new WebService.Venda();

                entVenda.Vn_desconto = Convert.ToDecimal(textBoxDes.Text);
                entVenda.Vn_valortotal = Convert.ToDecimal(textBoxValorPago.Text);
                entVenda.Vn_formapagamento = comboBoxFP.Text;
                entVenda.Vn_dtsaida = Convert.ToDateTime(dateTimePickerAtual.Text);
                entVenda.Vn_receita = Convert.ToInt32(txtIdReceita.Text);
                entVenda.Cliente = cliente;
                entVenda.Listaitens = listaDeItens.ToArray<ProdutoVenda>();

                    webservice.inserir(entVenda);
                    MessageBox.Show("Venda realizada com sucesso!");

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

                    doc.Save(@"C:\Users\Leonardo Marques\Desktop\SysOtica\SysOtica Prj\SysOtica Prj\VendasNFe.xml");
                    //Caminho Leo : C:\Users\Leonardo Marques\Desktop\Projeto Final DSD Melo\sysOticaFinal\SysOtica Prj\SysOtica Prj\VendasNFe.xml
                    MessageBox.Show("Nota Fiscal XML gerado com sucesso!");

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

                    comboBoxCliente.Enabled = true;
                    comboBoxProduto.Enabled = true;
                    buttonNovoItem.Enabled = true;
                    textBoxQtd.Enabled = true;
                    buttonExcluir.Enabled = true;
                    comboBoxCliente.Enabled = true;
                    dataGridViewItens.Rows.Clear();
                    #endregion
              
            }

            #endregion
 
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente apagar este item da venda?", "Apagar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
                {
                    dataGridViewItens.Rows.Remove(dataGridViewItens.CurrentRow);
                }
            }
            catch
            {
                MessageBox.Show("Selecione o produto que deseja excluir!", "Excluir item!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a compra?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
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

                        if (Convert.ToDateTime(coluna) < DateTime.Today)
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

        private void button3_Click(object sender, EventArgs e)
        {
            #region Limpando os Campos
            dataGridViewItens.Rows.Clear();
            dataGridViewItens.Refresh();
            textBoxQtd.Clear();
            textBoxDes.Clear();
            textBoxProdID.Clear();
            textBoxValor.Clear();
            textBox4.Clear();
            textBoxValorPago.Clear();

            comboBoxCliente.Enabled = true;
            comboBoxProduto.Enabled = true;
            buttonNovoItem.Enabled = true;
            textBoxQtd.Enabled = true;
            buttonExcluir.Enabled = true;
            comboBoxCliente.Enabled = true;
            dataGridViewItens.Rows.Clear();
            #endregion
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            //receitavenda.Count < 0
            comboBoxCliente.Enabled = false;
            try
            {
                int val;
                if (Int32.TryParse(comboBoxCliente.SelectedValue.ToString(), out val) && (comboBoxCliente.SelectedItem.ToString() != null))
                {
                    dataGridRec.Rows.Clear();
                    preencheReceita();
                    vencimentoReceita();
                }
            }
            catch
            {
                MessageBox.Show("Selecione o cliente!");
            }
        }

        public void preencheReceita()
        {
            // professor mecheu aqui 
            try
            {
                if (comboBoxCliente.SelectedItem.ToString() != null)
                {
                    receitavenda = webservice.vendaReceita().ToList<WebService.Receita>();
                    dataGridRec.DataSource = null;
                    dataGridRec.AutoGenerateColumns = false;
                    if (receitavenda.Count > 0)
                    {
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
                    

                        if (dataGridRec.RowCount == 0)
                        {
                            MessageBox.Show("O cliente selecionado não possui receitas cadastradas");

                            DialogResult resultado = MessageBox.Show("Deseja realmente continuar com essa Compra? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado == DialogResult.Yes)
                            {
                                comboBoxCliente.Enabled = false;
                                return;
                            }
                            else if (resultado == DialogResult.No)
                            {
                                comboBoxCliente.Enabled = true;
                                return;
                            }




                        }

                    }else
                    {
                        //
                    }

                }
            }
            catch
            {
                MessageBox.Show("Não existe receita cadastrada para esse cliente", "Receita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
