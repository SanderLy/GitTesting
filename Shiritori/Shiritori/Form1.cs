using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shiritori
{
    public partial class frmGame : Form
    {
        string used_path = Application.StartupPath.Replace("\\bin\\Debug", "\\used.txt");
        string dictionary_path = Application.StartupPath.Replace("\\bin\\Debug", "\\dictionary.txt");
        string used_words = Application.StartupPath + "\\used.txt";
        string dictionary = Application.StartupPath + "\\dictionary.txt";
        bool p1, p2;
        int p1_points = 0;
        int p2_points = 0;
        

        public frmGame()
        {
            InitializeComponent();          
        }

     private void btnOk_Click(object sender, EventArgs e)
        
     {         
            if (txtword.TextLength != 0)
            {
                bool word_played = File.ReadAllLines(dictionary).Contains(txtword.Text.ToLower());

                if (word_played == true)
                {
                    bool word_used = File.ReadAllLines(used_words).Contains(txtword.Text.ToLower());
                    if (word_used == false)
                    {
                        string[] prevword = this.Controls.OfType<TextBox>().Select(t => t.Text).ToArray();
                        lblpword.Text = txtword.Text;
                        

                        //storing the used words in a text file
                        TextWriter writer = new StreamWriter(used_words, true);
                        if (!File.Exists(used_words))
                        {
                            File.CreateText(used_words);
                            writer.WriteLine(txtword.Text.ToLower());
                            writer.Close();
                        }
                        // <--- check if created: used words list -- >
                        if (File.Exists(used_words))
                        {
                            writer.WriteLine(txtword.Text.ToLower());
                            writer.Close();
                            
                        }
                        scorer(txtword.Text.ToLower());
                        wordlenght_message(txtword.TextLength);
                        deadclock.Value = 100;
                        lblroundNo.Text = Convert.ToString(Convert.ToInt32(lblroundNo.Text) + 1);
                        txtword.Clear();
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
            }
            // <--- check if the textbox is empty -- >
            else
            {
                MessageBox.Show("Please enter a word", "Message");
            }
        }

     private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
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

     private void txtword_KeyPress(object sender, KeyPressEventArgs e)
     {
         if (e.KeyChar == (char)Keys.Return)
         {
             btnOk.PerformClick();
         }
     }

     private void frmGame_Load(object sender, EventArgs e)
     {
         //start player 1
         p1 = true;
         if (!File.Exists(used_words))
         {
             File.Copy(used_path,used_words);
             
         }
         if (!File.Exists(dictionary))
         {
             File.Copy(dictionary_path, dictionary);
         }
         deadtimer.Enabled = true;
     }

     private void button1_Click(object sender, EventArgs e)
     {
         this.Close();
     }
  
     private void deadtimer_Tick(object sender, EventArgs e)
     {

         //if (deadclock.Value>0)
         //{
         //    deadclock.Value -= 10;
         //}
         //if(deadclock.Value==0)
         //{ 
         //       MessageBox.Show("GAME OVER", "message");
                
         //}
         // these codes are working and has been commented for debugging purposes.
     }

     private void wordlenght_message(int wordlen)
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
     private void scorer(string word)
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
         MessageBox.Show(wscore.ToString());
         if (p1 ==  true)
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
     }
        private void det_winner(){
            if (lblroundNo.Text == "10")
            {
                if (p1_points > p2_points)
                {
                    MessageBox.Show ("Player 1 Wins!!!");
                }
                else if (p2_points > p1_points)
                {
                    MessageBox.Show("Player 2 Wins !!!");
                }
                else if (p1_points ==  p2_points)
                {
                    MessageBox.Show("It's a tie");
                }
            }
        }
    }
}
