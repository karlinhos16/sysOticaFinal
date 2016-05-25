using SysOticaForm.WebService;
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
    public partial class frmListarVendas : Form
    {
        private Service1Client webservice = new Service1Client();
        private List<Venda> listaVenda = new List<Venda>();

        public frmListarVendas()
        {
            InitializeComponent();
        }

        private void frmListarVendas_Load(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        void atualizaGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            listaVenda = webservice.ListaVenda().ToList<Venda>();
            dataGridView1.DataSource = listaVenda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string caracteres = "^[ a-zA-Z]+$";
                if (textBox1.Text.Length < 3)
                {

                    MessageBox.Show("Por Favor, digite um nome com no mínimo 3 caracteres");
                    return;
                }
                if (!Regex.IsMatch(textBox1.Text, caracteres))
                {
                    MessageBox.Show("Este campo só aceita letras");
                    return;
                }

                if (textBox1.Text != "")
                {

                    dataGridView1.DataSource = null;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = webservice.PuxaVenda(textBox1.Text.Trim());
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Este Cliente não possui venda cadastrada");
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao listar as vendas");

            }
        }
    }
}
