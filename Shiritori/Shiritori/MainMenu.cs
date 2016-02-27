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
        bool single, two, Hscore, LMan;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            single = false;
            two = false;
            Hscore = false;
            LMan = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlPlayers.Visible = true;

        }

        private void btnSPlayer_Click(object sender, EventArgs e)
        {
            pnlPlayers.Visible = false;
            pnlMode.Visible = true;
            two = false;
            single = true;
        }

        private void btnTPlayer_Click(object sender, EventArgs e)
        {
            pnlPlayers.Visible = false;
            pnlMode.Visible = true;
            single = false;
            two = true;
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            pnlMode.Visible = false;
            if(single == true)
            {
                pnlDifficulty.Visible = true;
            }
            if(two == true)
            {
                pnlNet.Visible = true;
            }
        }

        private void btnLastMan_Click(object sender, EventArgs e)
        {
            pnlMode.Visible = false;
            if (single == true)
            {
                pnlDifficulty.Visible = true;
            }
            if (two == true)
            {
                pnlNet.Visible = true;
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {

        }

        private void btnMedium_Click(object sender, EventArgs e)
        {

        }

        private void btnHard_Click(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {

        }

        private void btnHost_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Visible == false && pnlPlayers.Visible ==true)
            {
                pnlMenu.Visible = true;
                pnlPlayers.Visible = false;
            }
            else if (pnlPlayers.Visible == false && pnlMode.Visible == true)
            {
                pnlPlayers.Visible = true;
                pnlMode.Visible = false;
            }
            else if(pnlMode.Visible == false && pnlDifficulty.Visible == true)
            {
                pnlMode.Visible = true;
                pnlDifficulty.Visible = false;
            }
            else if (pnlMode.Visible == false && pnlNet.Visible == true)
            {
                pnlMode.Visible = true;
                pnlNet.Visible = false;
            }
          
            else if (pnlMenu.Visible == false && pnlHow.Visible == true)
            {
                pnlMenu.Visible = true;
                pnlHow.Visible = false;
            }
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlHow.Visible = true;
        }
    }
}
