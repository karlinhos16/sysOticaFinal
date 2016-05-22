﻿using SysOticaForm.WebService;
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
    public partial class frmListarProduto : Form
    {

        private Service1Client webservice = new WebService.Service1Client();
        private List<WebService.Produto> listarProduto = new List<WebService.Produto>();


        public frmListarProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        void atualizaGrid()
        {
            dataGridProduto.AutoGenerateColumns = false;
            dataGridProduto.DataSource = null;
            listarProduto = webservice.listarProduto().ToList<WebService.Produto>();
            dataGridProduto.DataSource = listarProduto;
            dataGridProduto.Update();


        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProduto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para alterar!");
                    return;
                }
                DialogResult resultado = MessageBox.Show("Deseja realmente alterar esse Produto? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    WebService.Produto pSelecionado;
                    pSelecionado = (dataGridProduto.SelectedRows[0].DataBoundItem as WebService.Produto);

                    formProdutoAlterar formAp = new formProdutoAlterar(pSelecionado);
                    DialogResult dialog = formAp.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        atualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto c = new WebService.Produto();

            try
            {
                if (dataGridProduto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma Linha para excluir!");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Produto?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    webservice.excluirProduto(listarProduto.ElementAt(dataGridProduto.SelectedRows[0].Index));
                    MessageBox.Show("Produto excluído com sucesso!");
                    atualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridProduto.DataSource = webservice.pesquisaProduto(btnPesquisar.Text);
        }

        private void dataGridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProduto.SelectedRows[0].Index >= 0)
            {
                MessageBox.Show("Campo Selecionado!");
                Produto pSelecionado = listarProduto.ElementAt(dataGridProduto.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Campo não selecionado!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

}


