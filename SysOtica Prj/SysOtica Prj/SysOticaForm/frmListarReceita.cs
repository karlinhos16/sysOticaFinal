using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using SysOtica.Negocio.Fachada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmListarReceita : Form
    {
        public List<Receita> listarReceita;
        Fachada fachada = new Fachada();

        public frmListarReceita()
        {
            InitializeComponent();
        }

    

        private void frmListarReceita_Load(object sender, EventArgs e)
        {
         

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            atualizaGrid();


      
        }

        void atualizaGrid()
        {
            DataGridreceita.AutoGenerateColumns = false;
            DataGridreceita.DataSource = null;
            listarReceita = fachada.ListaReceita();
            DataGridreceita.DataSource = listarReceita;
            vencimentoReceita();

        }


        void vencimentoReceita()
        {
            if (DataGridreceita != null)
            {
                DataGridreceita.AutoGenerateColumns = false;
                for (int i = 0; i < DataGridreceita.Rows.Count; i++)
                {
                    string coluna = DataGridreceita.Rows[i].Cells[27].Value.ToString();

                    if (Convert.ToString(coluna) == DateTime.Today.ToString() && Convert.ToDateTime(coluna) != null)
                    {

                        DataGridreceita.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        DataGridreceita.Rows[i].ErrorText = "Esta receita se encontra na data de vencimento";
                    }

                    else
                    {
                        DataGridreceita.Rows[i].DefaultCellStyle.BackColor = Color.White;


                    }

                }


            }


        }




        private void receitaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridreceita.SelectedRows[0].Index >= 0)
            {

                try
                {
                    Receita receitaSelecionada = listarReceita.ElementAt(DataGridreceita.SelectedRows[0].Index);
                    MessageBox.Show("Campo Selecionado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valor nulo \n" + ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Campo não selecionado!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridreceita.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para alterar!");
                    return;
                }
                DialogResult resultado = MessageBox.Show("Deseja realmente alterar essa Receita? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Receita receitaSelecionada;
                    receitaSelecionada = (DataGridreceita.SelectedRows[0].DataBoundItem as Receita);

                    frmReceitaAlterar formAR = new frmReceitaAlterar(receitaSelecionada);
                    DialogResult dialog = formAR.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        atualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new GuidVazioException("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Receita receita = new Receita();

            try
            {
                if (DataGridreceita.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma Linha para excluir!");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir essa Receita?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    fachada.ExcluirReceita(listarReceita.ElementAt(DataGridreceita.SelectedRows[0].Index));
                    MessageBox.Show("Receita excluído com sucesso!");
                    atualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados. \n" + ex.Message);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //DataGridreceita.DataSource = fachada.PesquisaReceita(btnPesquisar.Text);



            string caracteres = "^[ a-zA-Z]+$";
            if (txtPesquisa.Text.Length < 3)
            {

                MessageBox.Show("Por Favor, digite um nome com no mínimo 3 caracteres");
                return;
            }
            if (!Regex.IsMatch(txtPesquisa.Text, caracteres))
            {
                MessageBox.Show("Este campo só aceita letras");
                return;
            }

            if (txtPesquisa.Text != "")
            {

                DataGridreceita.DataSource = null;
                DataGridreceita.AutoGenerateColumns = false;
                //fachada.PesquisaReceitas(DataGridreceita, this.txtPesquisa.Text.Trim());
                DataGridreceita.DataSource = fachada.PuxaReceita(txtPesquisa.Text.Trim());
                vencimentoReceita();

            }




        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DataGridreceita.DataSource = null;
        }
    }


}




