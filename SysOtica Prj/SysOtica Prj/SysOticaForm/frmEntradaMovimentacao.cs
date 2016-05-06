using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
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
    public partial class frmEntradaMovimentacao : Form
    {
        public frmEntradaMovimentacao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmEntradaMovimentacao_Load(object sender, EventArgs e)
        {
            CarregaForncedores();

            CarregaProduto();


        }



        public void LimparCampos()
        {

            textquantidade.Text = "";
            dateTimedtEntrada.Text = "";
            cmbProduto.Text = "";
            cmbEntrada.Text = "";
            cmbFornecedor.Text = "";
            richTextObs.Text = "";

        }

        private void CarregaProduto()
        {
            ProdutoDados pd = new ProdutoDados();
            Produto p = new Produto();            
            List<Produto> carregaproduto = pd.listarProduto();
            DataTable dt = new DataTable();

            dt.Columns.Add("pr_id");
            dt.Columns.Add("pr_descricao");

            foreach (Produto ps in carregaproduto)
            {
                DataRow row = dt.NewRow();
                row["pr_id"] = ps.Pr_id;
                row["pr_descricao"] = ps.Pr_descricao;
                dt.Rows.Add(row);
            }

            cmbProduto.DataSource = dt;
            cmbProduto.DisplayMember = "pr_descricao";
            cmbProduto.ValueMember = "pr_id";
        }


        private void CarregaForncedores()
        {

            FornecedoresDados fd = new FornecedoresDados();          
            Fornecedor f = new Fornecedor();
            List<Fornecedor> carregaforn = fd.listaFornecedor();
            

             DataTable dt = new DataTable();

            dt.Columns.Add("fr_id");
            dt.Columns.Add("fr_fantasia");

            foreach (Fornecedor fr in carregaforn)
            {
                DataRow row = dt.NewRow();
                row["fr_id"] = fr.Fr_id;
                row["fr_fantasia"] = fr.Fr_fantasia;
                dt.Rows.Add(row);
            }

            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "fr_fantasia";
            cmbFornecedor.ValueMember = "fr_id";



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoFornecedor pf = new ProdutoFornecedor();

            try
            {


                pf.P.Pr_id = Convert.ToInt32(cmbProduto.SelectedValue.ToString());
                pf.F.Fr_id = Convert.ToInt32(cmbFornecedor.SelectedValue.ToString());
                pf.Pf_qtd = Convert.ToInt32(textquantidade.Text);
                pf.Pf_dtentrada = Convert.ToDateTime(dateTimedtEntrada.Text);
                pf.Pf_tipo = cmbEntrada.SelectedItem.ToString();
                pf.Pf_observacoes = richTextObs.Text;
                ProdutoFornecedorDados pfd = new ProdutoFornecedorDados();
                pfd.inserir(pf);
                MessageBox.Show("Produto fornecedor inserido com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Produto ao Fornecedor" + ex.Message);

            }
        }
    }
}
