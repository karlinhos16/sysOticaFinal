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
    public partial class formCategoria : Form
    {

        private Service1Client webservice = new Service1Client();
        private WebService.Categoria categoria = new WebService.Categoria();
        
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

            string categoria;

            categoria = comboCat.SelectedItem.ToString();

            MessageBox.Show("a opção escolhida foi:  " + categoria);


            try
            {
                categoria.Ct_nome = Convert.ToString(comboCat.SelectedItem.ToString());
                               
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

