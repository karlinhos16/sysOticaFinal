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
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            string categoria;

            categoria = comboCat.SelectedItem.ToString();

            MessageBox.Show("a opção escolhida foi:  " + categoria);


            try
            {

                Categoria cat = new Categoria();

                cat.Ct_nome = Convert.ToString(comboCat.SelectedItem.ToString());

                Fachada fac = new Fachada();
                fac.cadastraCat(cat);
                MessageBox.Show("Categoria cadastra com sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar categoria" + ex.Message);
            }


        }












    }






        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
