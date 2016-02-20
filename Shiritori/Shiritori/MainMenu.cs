using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace Shiritori
{
    public partial class MainMenu : Form
    {
        Form game = new mGame();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void RunThread()
        {
            Thread TcpServerRunThread = new Thread(new ThreadStart(TcpServerRun));
            TcpServerRunThread.Start();
        }
         private void StopThread()
        {
            Thread TcpServerRunThread = new Thread(new ThreadStart(TcpServerRun));
            TcpServerRunThread.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //RunThread();
            game.Show();
        }

        private void TcpServerRun()
        {
            TcpListener tcpListner = new TcpListener(IPAddress.Any, 5004);
            tcpListner.Start();
            updateUI("Listening");
            while(true)
            {
                TcpClient client = tcpListner.AcceptTcpClient();
                Thread tcpHandlerThread = new Thread (new ParameterizedThreadStart(tcpHandler));
                tcpHandlerThread.Start(client);
            }

        }

        private void tcpHandler (object client)
        {
            TcpClient mClient = (TcpClient) client;
            NetworkStream stream = mClient.GetStream();
            byte[] message = new byte[1024];
            stream.Read(message,0,message.Length);
            updateUI("Message from client: " + Encoding.ASCII.GetString(message));
            stream.Close();
            mClient.Close();
        }
        private void updateUI(string s)
        {
            Func<int> del = delegate()
            {
               textBox1.AppendText(System.Environment.NewLine+s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void MainMenu_Leave(object sender, EventArgs e)
        {
            StopThread();
  
        }
    }
}
