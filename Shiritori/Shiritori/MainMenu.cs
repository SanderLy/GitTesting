using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiritori
{
    public partial class MainMenu : Form
    {
        Network tcp_class = new Network();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tcp_class.Start_Server();
            txttry.Text = ">> Server Started" + "\n";
        }
    }
}
