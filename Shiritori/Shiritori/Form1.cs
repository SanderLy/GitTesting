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
        int a_points;
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
                            wordlenght_message(txtword.TextLength);
                            scorer(txtword.Text);
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
         a_points = 0;
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

         if (deadclock.Value<100)
         {
             deadclock.Value += 1;
         }
         if(deadclock.Value==100)
         { 
             
                 deadtimer.Enabled = false;
                 MessageBox.Show("GAME OVER", "message");
             
            
         }
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
         a_points += wscore;
         a_score.Text = String.Format("{0:0000000000}",a_points); 
     }

    }
}
