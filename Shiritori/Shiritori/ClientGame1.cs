﻿using System;
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
using System.Web;

namespace Client
{
    public partial class mGame : Form
    {
        string last_let = "";
        string used_path = Application.StartupPath.Replace("\\bin\\Debug", "\\used.txt");
        string dictionary_path = Application.StartupPath.Replace("\\bin\\Debug", "\\dictionary.txt");
        string used_words = Application.StartupPath + "\\used.txt";
        string dictionary = Application.StartupPath + "\\dictionary.txt";
        char[] prevword = new char[1024];
        bool p1, p2;
        int p1_points = 0;
        int p2_points = 0;

        int i;
        TcpClient client; // Creates a TCP Client
        NetworkStream stream; //Creats a NetworkStream (used for sending and receiving data)
        byte[] datalength = new byte[4]; // creates a new byte with length 4 ( used for receivng data's lenght)
        string server_ip = null;
        public void wordlenght_message(int wordlen)
        {
            if (wordlen > 10)
            {
                MessageBox.Show("Excellent", "Message");
            }
            else if (wordlen < 10 && wordlen > 7)
            {
                MessageBox.Show("Awesome", "Message");
            }
            else
            {
                MessageBox.Show("Good", "Message");
            }
        }

        public void scorer(string word)
        {
            char[] value = word.ToCharArray();
            int wscore = 0; //current word score;
            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case 'a':
                        wscore = wscore + 100;
                        break;
                    case 'e':
                        wscore = wscore + 100;
                        break;
                    case 'i':
                        wscore = wscore + 100;
                        break;
                    case 'o':
                        wscore = wscore + 100;
                        break;
                    case 'u':
                        wscore = wscore + 100;
                        break;
                    case 'l':
                        wscore = wscore + 100;
                        break;
                    case 'n':
                        wscore = wscore + 100;
                        break;
                    case 'r':
                        wscore = wscore + 100;
                        break;
                    case 's':
                        wscore = wscore + 100;
                        break;
                    //end of 100pts
                    case 'd':
                        wscore = wscore + 200;
                        break;
                    case 'g':
                        wscore = wscore + 200;
                        break;
                    //end of 200pts
                    case 'b':
                        wscore = wscore + 300;
                        break;
                    case 'c':
                        wscore = wscore + 300;
                        break;
                    case 'm':
                        wscore = wscore + 300;
                        break;
                    case 'p':
                        wscore = wscore + 300;
                        break;
                    //end of 300pts
                    case 'f':
                        wscore = wscore + 400;
                        break;
                    case 'h':
                        wscore = wscore + 400;
                        break;
                    case 'v':
                        wscore = wscore + 400;
                        break;
                    case 'w':
                        wscore = wscore + 400;
                        break;
                    case 'y':
                        wscore = wscore + 400;
                        break;
                    //end of 400pts
                    case 'k':
                        wscore = wscore + 700;
                        break;
                    case 'j':
                        wscore = wscore + 700;
                        break;
                    //end of 700pts
                    case 'x':
                        wscore = wscore + 1000;
                        break;
                    case 'q':
                        wscore = wscore + 1000;
                        break;
                    case 'z':
                        wscore = wscore + 1000;
                        break;
                }
            }

            if (p1 == true)
            {
                p1_points += wscore;
                p1_score.Text = String.Format("{0:000000000}", p1_points);
                p1 = false;
                p2 = true;
            }
            else
            {
                p2_points += wscore;
                p2_score.Text = String.Format("{0:000000000}", p2_points);
                p2 = false;
                p1 = true;
            }
            det_winner();
        }
        public void ChangePlayer()
        {
            if (p1 == true)
            {
                btnOk.Enabled = true;
                txtword.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
                txtword.Text = null;
                txtword.Enabled = false;
            }
        }

        public void det_winner()
        {
            if (lblroundNo.Text == "10")
            {
                if (p1_points > p2_points)
                {
                    MessageBox.Show("Player 1 Wins!!!");
                    this.Close();
                }
                else if (p2_points > p1_points)
                {
                    MessageBox.Show("Player 2 Wins !!!");
                    this.Close();
                }
                else if (p1_points == p2_points)
                {
                    MessageBox.Show("It's fa tie");
                    this.Close();
                }
            }
        }
        public void GetLastLetter(string word)
        {
            last_let = word.Substring(word.Length - 1);

        }

       //start of network codes
        
        public void ClientReceive()
        {

            stream = client.GetStream(); //Gets The Stream of The Connection
            new Thread(() => 
            {
                while ((i = stream.Read(datalength, 0, 4)) != 0)//Keeps Trying to Receive the Size of the Message or Data
                {
                   
                    byte[] data = new byte[BitConverter.ToInt32(datalength, 0)]; // Creates a Byte for the data to be Received On
                    stream.Read(data, 0, data.Length); //Receives The Real Data not the Size
                    this.Invoke((MethodInvoker)delegate // To Write the Received data
                    {
                        lblpword.Text =Encoding.Default.GetString(data); // Encoding.Default.GetString(data); Converts Bytes Received to String
                    });
                }
            }).Start(); 
        }

        public void ClientSend(string msg)
        {
            stream = client.GetStream(); //Gets The Stream of The Connection
            byte[] data; // creates a new byte without mentioning the size of it cuz its a byte used for sending
            data = Encoding.Default.GetBytes(msg); // put the msg in the byte ( it automaticly uses the size of the msg )
            int length = data.Length; // Gets the length of the byte data
            byte[] datalength = new byte[4]; // Creates a new byte with length of 4
            datalength = BitConverter.GetBytes(length); //put the length in a byte to send it
            stream.Write(datalength, 0, 4); // sends the data's length
            stream.Write(data, 0, data.Length); //Sends the real data
        }

        //end of network codes

        public mGame()
        {
            InitializeComponent();
        }

        public void btnSend_Click(object sender, EventArgs e)
        {
            if (txtword.TextLength != 0)
            {
                if (txtword.Text.StartsWith(last_let) == true || last_let == "")
                {
                    bool word_played = File.ReadAllLines(dictionary).Contains(txtword.Text.ToLower());

                    if (word_played == true)
                    {
                        bool word_used = File.ReadAllLines(used_words).Contains(txtword.Text.ToLower());
                        if (word_used == false)
                        {

                            lblpword.Text = txtword.Text.ToLower();
                            wordlenght_message(txtword.TextLength);
                            deadclock.Value = 100;
                            //network codes....
                            if (client.Connected) // if the client is connected
                            {
                                ClientSend(lblpword.Text.ToLower()); // uses the Function ClientSend and the msg as txtSend.Text
                            }
                        }

                        // <--- check if word is already used -- >
                        else
                        {
                            MessageBox.Show("Word is already used. Try something else.", "Message");
                        }
                    }
                    // <--- check word inside the dictionary -- >
                    else
                    {
                        MessageBox.Show("Word does not exist in the dictionary.", "Message");
                    }
                }//  <--- check last letter of the previous word -- >
                else
                {
                    MessageBox.Show("Letters does not match.", "Message");
                }
            }

            // <--- check if the textbox is empty -- >
            else
            {
                MessageBox.Show("Please enter a word", "Message");
            }
        }

        public void btnSaveIP_Click(object sender, EventArgs e)
        {
            try
            {
                server_ip = txtIP.Text;
                try
                {
                    client = new TcpClient(server_ip, 1980); //Trys to Connect
                    ClientReceive(); //Starts Receiving When Connected
                    txtIP.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // Error handle
                }
            }
            catch
            {
                MessageBox.Show("There has been an error. Please check the IP address of the server.");
            }
        }

        public void mClient_Load(object sender, EventArgs e)
        {
            p1 = true;
            if (!File.Exists(used_words))
            {
                File.Copy(used_path, used_words);
            }
            if (!File.Exists(dictionary))
            {
                File.Copy(dictionary_path, dictionary);
            }
        }

        public void mClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(dictionary))
            {
                File.Delete(dictionary);

            }
            if (File.Exists(used_words))
            {
                File.Delete(used_words);
            } 
        }

        public void lblpword_TextChanged(object sender, EventArgs e)
        {
            GetLastLetter(lblpword.Text);
            scorer(lblpword.Text.ToLower());
            lblroundNo.Text = Convert.ToString(Convert.ToInt32(lblroundNo.Text) + 1);
            ChangePlayer();
            //storing the used words in a text file
            TextWriter writer = new StreamWriter(used_words, true);
            if (!File.Exists(used_words))
            {
                File.CreateText(used_words);
                writer.WriteLine(lblpword.Text.ToLower());
                writer.Close();
            }
            // <--- check if created: used words list -- >
            if (File.Exists(used_words))
            {
                writer.WriteLine(lblpword.Text.ToLower());
                writer.Close();

            }
        }

    
    }
}
