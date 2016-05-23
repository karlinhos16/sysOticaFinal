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
    public partial class formCategoria : Form
    {

        private Service1Client webservice = new Service1Client();
        private Categoria categoria = new Categoria();

        public formCategoria()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria();

            try
            {
                categoria.Ct_nome = textcat.Text;
                webservice.cadastraCat(categoria);
                MessageBox.Show("Categoria cadastra com sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar categoria" + ex.Message);
            }


        }












    }







}

