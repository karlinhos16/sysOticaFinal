using SocketSysOticaClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfSysOticaClient.ServiceReference1;

namespace WcfSysOticaClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       

            try
            {
                Thread t = new Thread(CliList);

                CliList();
                groupBox1.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void CliList()
        {
            try
            {
                List<Cliente> clienteL = new List<Cliente>();
                Cliente c = new Cliente()
                {
                    cl_id = Convert.ToInt32(txtID.Text)
                };
                Service1Client service = new Service1Client();
                clienteL.Add(service.GetCliente(c));
                dgvClientes.DataSource = clienteL;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Socket_Client___DSD_MELO skt = new Socket_Client___DSD_MELO();
                skt.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
