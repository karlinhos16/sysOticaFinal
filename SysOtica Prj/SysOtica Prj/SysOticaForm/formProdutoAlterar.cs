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
    public partial class formProdutoAlterar : Form
    {
        private Service1Client webservice = new Service1Client();
        private Produto produto = new Produto();
        private List<Fornecedor> listfornecedor = new List<Fornecedor>();
        private List<Categoria> listcategoria = new List<Categoria>();

        string[] oculos = {"Arnette","Blue Bay","Christian Dior", "D&G",
                           "Diesel","Armani","mormaii","Oakley","Ray-Ban","Ralph Lauren","HB","Tommy Hilfiger",
                           "Turma da Mônica","Lacoste","Adidas","Playboy","Ray-Ban","Pierre Cardin","Hugo Boss"};

        string[] lentes = { "Transitions", "Hoya", "ZEISS", "Varilux" };

        string[] lentesContato = { "Acuvue", "Alcon", "CooperVision", "Solótica", "ZEISS" };

        public formProdutoAlterar(Produto p)
        {
            InitializeComponent();

            this.produto = p;

            if (produto != null)
            {
                textID.Text = Convert.ToString(produto.Pr_id);
                tbDescricao.Text = produto.Pr_descricao.ToString();
                cmbUnidade.Text = produto.Pr_unidade.ToString();
                cbGrife.Text = produto.Pr_grife;
                tbValor.Text = Convert.ToString(produto.Pr_valor);
                tbQuantidade.Text = Convert.ToString(produto.Pr_qtd);
                tbEstoqueMinimo.Text = Convert.ToString(produto.Pr_estoqueminimo);
                cmbCategoria.Text = produto.Categoria.Ct_nome;
                cmbFornecedor.Text = produto.Fornecedor.Fr_fantasia;
                     

            }
        }
  

      

      


        public void LimparCampos()
        {
            tbDescricao.Text = "";
            cmbUnidade.Text = "";
            cbGrife.Text = "";
            tbValor.Text = "";
            tbQuantidade.Text = "";
            tbEstoqueMinimo.Text = "";
        }

        private void formProdutoAlterar_Load(object sender, EventArgs e)
        {
            carregaFornecedor();

            carregaCategoria();


        }

        void carregaFornecedor()
        {

            listfornecedor = webservice.ListaFornecedor().ToList<Fornecedor>();

            DataTable data = new DataTable();

            data.Columns.Add("fr_id");
            data.Columns.Add("fr_fantasia");


            foreach (Fornecedor fornecedor in listfornecedor)
            {
                DataRow row = data.NewRow();
                row["fr_id"] = fornecedor.Fr_id;
                row["fr_fantasia"] = fornecedor.Fr_fantasia;
                data.Rows.Add(row);

            }

            cmbFornecedor.DataSource = data;
            cmbFornecedor.DisplayMember = "fr_fantasia";
            cmbFornecedor.ValueMember = "fr_id";


        }


        void carregaCategoria()
        {

            listcategoria = webservice.pesquisaCategoria().ToList<Categoria>();

            DataTable data = new DataTable();

            data.Columns.Add("ct_id");
            data.Columns.Add("ct_nome");


            foreach (Categoria cat in listcategoria)
            {
                DataRow row = data.NewRow();
                row["ct_id"] = cat.Ct_id;
                row["ct_nome"] = cat.Ct_nome;
                data.Rows.Add(row);

            }

            cmbCategoria.DataSource = data;
            cmbCategoria.DisplayMember = "ct_nome";
            cmbCategoria.ValueMember = "ct_id";

        }



        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1)
            {

                MessageBox.Show("Selecione uma categoria, por favor");
                return;
            }

            else if (cmbCategoria.SelectedIndex == 0)// seleciona o primeiro index do combobox
            {
                cbGrife.Items.Clear();
                for (int i = 0; i < oculos.Count(); i++)
                {
                    cbGrife.Items.Add(oculos[i]);// carrega combobox caso o index selecionado seja = 0
                }


            }
            else if (cmbCategoria.SelectedIndex == 1)
            {

                cbGrife.Items.Clear();
                for (int i = 0; i < lentes.Count(); i++)
                {
                    cbGrife.Items.Add(lentes[i]);
                }


            }
            else if (cmbCategoria.SelectedIndex == 2)
            {
                cbGrife.Items.Clear();
                for (int i = 0; i < lentesContato.Count(); i++)
                {
                    cbGrife.Items.Add(lentesContato[i]);
                }

            }
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {


                {
                    produto.Fornecedor = new Fornecedor();
                    produto.Categoria = new Categoria();

                    produto.Pr_descricao = tbDescricao.Text;
                    produto.Pr_unidade = cmbUnidade.Text.ToString();
                    produto.Pr_grife = cbGrife.Text.ToString();
                    string data_entrada = dataPicker.Value.ToShortDateString();
                    produto.Pr_dtentrada = Convert.ToDateTime(data_entrada);
                    produto.Pr_valor = Convert.ToDecimal(tbValor.Text);
                    produto.Pr_qtd = int.Parse(tbQuantidade.Text);
                    produto.Pr_estoqueminimo = int.Parse(tbEstoqueMinimo.Text);

                   // int aux = 0;
                    //int.TryParse(cmbFornecedor.SelectedValue.ToString(), out aux);
                    produto.Fornecedor.Fr_id = Convert.ToInt32(cmbFornecedor.SelectedValue.ToString());
                    //int.TryParse(cmbCategoria.SelectedValue.ToString(), out aux);
                    produto.Categoria.Ct_id = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());
                }
                if (produto == null)
                {
                    webservice.AlterarProduto(produto);
                    MessageBox.Show("Produto alterado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    produto.Fornecedor = new Fornecedor();
                    produto.Categoria = new Categoria();

                    produto.Pr_descricao = tbDescricao.Text;
                    produto.Pr_unidade = cmbUnidade.Text.ToString();
                    produto.Pr_grife = cbGrife.Text.ToString();
                    string data_entrada = dataPicker.Value.ToShortDateString();
                    produto.Pr_dtentrada = Convert.ToDateTime(data_entrada);
                    produto.Pr_valor = Convert.ToDecimal(tbValor.Text);
                    produto.Pr_qtd = int.Parse(tbQuantidade.Text);
                    produto.Pr_estoqueminimo = int.Parse(tbEstoqueMinimo.Text);

                    // int aux = 0;
                    //int.TryParse(cmbFornecedor.SelectedValue.ToString(), out aux);
                    produto.Fornecedor.Fr_id = Convert.ToInt32(cmbFornecedor.SelectedValue.ToString());
                    //int.TryParse(cmbCategoria.SelectedValue.ToString(), out aux);
                    produto.Categoria.Ct_id = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());


                    webservice.AlterarProduto(produto);
                    MessageBox.Show("Produto alterado com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
