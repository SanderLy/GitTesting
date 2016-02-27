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

    }
}
