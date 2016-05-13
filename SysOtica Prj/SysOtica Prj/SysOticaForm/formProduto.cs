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
using SysOtica.Negocio;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Conexao;
using System.Collections;
using SysOtica.Negocio.Fachada;

namespace SysOticaForm
{
    public partial class formProduto : Form
    {
        string[] oculossol = {"Arnette","Blue Bay","Christian Dior", "D&G",
                               "Diesel","Armani","mormaii","Oakley","Ray-Ban","Ralph Lauren","HB" };

        string[] oculosgrau = {"Pirre Cardin","Hugo Boss","Tommy Hilfiger", "D&G",
                              "Turma da Mônica","Lacoste","Adidas","Playboy","Ray-Ban","Ralph Lauren","Evoke" };

        string[] lentes = { "Transitions", "Hoya", "ZEISS", "Varilux" };

        string[] lentesContato = { "Acuvue", "Alcon", "CooperVision", "Solótica", "ZEISS" };





        public formProduto()
        {
            InitializeComponent();
        }

        private void formProduto_Load(object sender, EventArgs e)
        {
            carregaFornecedor();

            carregaCategoria();


            


        }





        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrupo.SelectedIndex == 0)// seleciona o primeiro index do combobox
            {

                for (int i = 0; i < oculosgrau.Count(); i++) // carrega combobox caso o index selecionado seja = 0
                {
                    cbGrife.Items.Add(oculosgrau[i]);
                }

            }

            else if (cbGrupo.SelectedIndex == 1)
            {
                cbGrife.Items.Clear();
                for (int j = 0; j < oculossol.Count(); j++)
                {
                    cbGrife.Items.Add(oculossol[j]);
                }

            }
            else if (cbGrupo.SelectedIndex == 2)
            {
                cbGrife.Items.Clear();
                for (int j = 0; j < lentes.Count(); j++)
                {
                    cbGrife.Items.Add(lentes[j]);
                }

            }
            else if (cbGrupo.SelectedIndex == 3)
            {
                cbGrife.Items.Clear();
                for (int j = 0; j < lentesContato.Count(); j++)
                {
                    cbGrife.Items.Add(lentesContato[j]);
                }

            }
            else
            {
                MessageBox.Show("Selecione o uma categoria!");
            }
        }


        void carregaFornecedor()
        {
            FornecedoresDados dadosforn = new FornecedoresDados();
            List<Fornecedor> lista;
            lista = dadosforn.listaFornecedor();

            DataTable data = new DataTable();

            data.Columns.Add("fr_id");
            data.Columns.Add("fr_fantasia");


          foreach (Fornecedor fornecedor in lista)
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
            CategoriaDados dadoscat = new CategoriaDados();
            List<Categoria> lista;
            lista = dadoscat.pesquisaCategoria();

            DataTable data = new DataTable();

            data.Columns.Add("ct_id");
            data.Columns.Add("ct_nome");


            foreach (Categoria cat in lista)
            {
                DataRow row = data.NewRow();
                row["ct_id"] = cat.Ct_id;
                row["ct_nome"] = cat.Ct_nome;
                data.Rows.Add(row);

            }

            cmbFornecedor.DataSource = data;
            cmbFornecedor.DisplayMember = "ct_nome";
            cmbFornecedor.ValueMember = "ct_id";

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Fachada fachada = new Fachada();
                Fornecedor fornecedor = new Fornecedor();
                Produto produto = new Produto();
                Categoria cat = new Categoria();

                // string forn = cbFornecedor.SelectedItem.ToString();
                //          int fornecedorID = Convert.ToInt32(forn.Substring(0, 1));//pega somente o ID do fornecedor


                {
                    fornecedor.Fr_id = Convert.ToInt32(cmbFornecedor.SelectedValue.ToString());
                    cat.Ct_id = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());
                    produto.Pr_descricao = tbDescricao.Text;
                    produto.Pr_unidade = cmbUnidade.SelectedItem.ToString();
                    produto.Pr_grife = cbGrife.SelectedItem.ToString();
                    string data_entrada = dataPicker.Value.ToShortDateString();
                    produto.Pr_dtentrada = Convert.ToDateTime(data_entrada);
                    produto.Pr_valor = int.Parse(tbValor.Text);
                    produto.Pr_qtd = int.Parse(tbQuantidade.Text);
                    produto.Pr_estoqueminimo = int.Parse(tbEstoqueMinimo.Text);

                }
                fachada.InserirProduto(produto, fornecedor, cat);
                MessageBox.Show("Produto Cadastrado com Sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Cadastro" + ex.Message);
            }

        }



          public void LimparCampos()
         {
            tbDescricao.Text = "";
            dataPicker.Text = null;
            cbGrupo.Text = "";
            cmbUnidade.Text = "";
            cbGrife.Text = "";
            tbValor.Text = "";
            tbQuantidade.Text = "";
            tbEstoqueMinimo.Text = "";
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }



        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }




        }


}
    
