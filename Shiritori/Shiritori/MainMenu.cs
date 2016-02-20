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
using Transitions;
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

        private void button1_Click(object sender, EventArgs e)
        {
            game.Show();
        }

        private void splay_Click(object sender, EventArgs e)
        {

        }
    }
}
