using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace SocketSysOticaClient
{
    public partial class Socket_Client___DSD_MELO : Form
    {

        TcpClient tcpClient;
        NetworkStream networkStream;
        Thread thInteraction;


        public Socket_Client___DSD_MELO()
        {
            InitializeComponent();
        }

        private void connect()
        {
            tcpClient = new TcpClient();
            setMsg("## Estabelecendo Conexão...");
            tcpClient.Connect("127.0.0.1", 8000);

        }

        private void disconnect()
        {
            if (thInteraction != null)
            {
                if (thInteraction.ThreadState == ThreadState.Running)
                    thInteraction.Abort();
            }

            tcpClient.Close();
        }


        private void enviarMsg(string mensagem)
        {
            if (networkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }


        delegate void delSetMsg(string mensagem);
        private void setMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delSetMsg(setMsg), mensagem);
            }
            else
            {
                rtbConversa.Text = "Eu: " + mensagem + "\n";
            }
        }

        delegate void delGetMsg(string mensagem);
        private void GetMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delGetMsg(GetMsg), mensagem);
            }
            else
            {
                rtbConversa.Text = "Server: " + mensagem + "\n";
            }
        }

        private void rtbMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (networkStream.CanWrite)
                {
                    string mensagem = rtbMensagem.Text;
                    enviarMsg(mensagem);
                    setMsg(mensagem);
                }
                else
                {
                    setMsg("## Não é possível enviar dados ao servidor...");
                    disconnect();
                }
            }
        }

        private void rtbMensagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbMensagem.Clear();
            }
        }


        private void interaction()
        {
            try
            {
                do
                {
                    
                } while (tcpClient.Connected);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
