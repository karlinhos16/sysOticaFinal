using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Fachada;
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
        Produto alteraProduto;
        Fachada fachada = new Fachada();

        string[] oculossol = {"Arnette","Blue Bay","Christian Dior", "D&G",
                               "Diesel","Armani","mormaii","Oakley","Ray-Ban","Ralph Lauren","HB" };

        string[] oculosgrau = {"Pirre Cardin","Hugo Boss","Tommy Hilfiger", "D&G",
                              "Turma da Mônica","Lacoste","Adidas","Playboy","Ray-Ban","Ralph Lauren","Evoke" };

        string[] lentes = { "Transitions", "Hoya", "ZEISS", "Varilux" };

        string[] lentesContato = { "Acuvue", "Alcon", "CooperVision", "Solótica", "ZEISS" };


        string[] categoria = { "Oculos de Grau", "Oculos de Sol", "Lente Bifocais ou Multifocais", "Lentes de Contato" };





        public formProdutoAlterar(Produto p)
        {
            InitializeComponent();

            this.alteraProduto = p;

            if (alteraProduto != null)

            {

                 

                textID.Text = Convert.ToString(alteraProduto.Pr_id);
                tbDescricao.Text = alteraProduto.Pr_descricao;
                cmbUnidade.Text = alteraProduto.Pr_unidade;               
                cbGrupo.Text = alteraProduto.Pr_Categoria;
                cbGrife.Text = alteraProduto.Pr_grife;
                tbValor.Text = Convert.ToString(alteraProduto.Pr_valor);
                tbQuantidade.Text = Convert.ToString(alteraProduto.Pr_qtd);
                tbEstoqueMinimo.Text = Convert.ToString(alteraProduto.Pr_estoqueminimo);

            }


        }


      
    

 



        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();

                {
                    p.Pr_id = Convert.ToInt32(textID.Text);
                    p.Pr_descricao = tbDescricao.Text;
                    p.Pr_unidade = cmbUnidade.SelectedItem.ToString();
                    p.Pr_Categoria = cbGrupo.SelectedItem.ToString();
                    p.Pr_grife = cbGrife.SelectedItem.ToString();
                    p.Pr_valor = Convert.ToDecimal(tbValor.Text);
                    p.Pr_qtd = Convert.ToInt32(tbQuantidade.Text);
                    p.Pr_estoqueminimo = Convert.ToInt32(tbEstoqueMinimo.Text);
              
                }
                if (alteraProduto == null)
                {
                    fachada.AlterarProduto(p);
                    MessageBox.Show("Produto alterado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    alteraProduto.Pr_id = Convert.ToInt32(textID.Text);
                    alteraProduto.Pr_descricao = tbDescricao.Text;
                    alteraProduto.Pr_unidade = cmbUnidade.SelectedItem.ToString();
                    alteraProduto.Pr_Categoria = cbGrupo.SelectedItem.ToString();
                    alteraProduto.Pr_grife = cbGrife.SelectedItem.ToString();
                    alteraProduto.Pr_valor = Convert.ToDecimal(tbValor.Text);
                    alteraProduto.Pr_qtd = Convert.ToInt32(tbQuantidade.Text);
                    alteraProduto.Pr_estoqueminimo = Convert.ToInt32(tbEstoqueMinimo.Text);

                    fachada.AlterarProduto(alteraProduto);
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
        public void LimparCampos()
        {
            tbDescricao.Text = "";
            cmbUnidade.Text = "";                
            cbGrupo.Text = "";
            cbGrife.Text = "";
            tbValor.Text = "";
            tbQuantidade.Text = "";
            tbEstoqueMinimo.Text = "";
        }

        private void formProdutoAlterar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < categoria.Count(); i++)
            {
                cbGrupo.Items.Add(categoria[i]);
            }
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
            else {
                MessageBox.Show("Selecione o uma categoria!");
            }
        }
    }
}
