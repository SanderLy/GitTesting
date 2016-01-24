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
        public frmGame()
        {
            
            InitializeComponent();
           
        }

     private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtword.TextLength != 0) 
            {
                bool word_played = File.ReadAllText(dictionary).Contains(txtword.Text);
                if (word_played == true)
                {
                    bool word_used = File.ReadAllText(used_words).Contains(txtword.Text);
                    if (word_used == false)
                    {
                        TextWriter writer = new StreamWriter(used_words, true);
                        if (!File.Exists(used_words))
                        {
                            File.CreateText(used_words);
                            writer.WriteLine(txtword.Text);
                            writer.Close();
                        }
                        // <--- check if created: used words list -- >
                        if (File.Exists(used_words))
                        {
                            writer.WriteLine(txtword.Text);
                            writer.Close();
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
         if (!File.Exists(used_words))
         {
             File.Copy(used_path,used_words);
             
         }
         if (!File.Exists(dictionary))
         {
             File.Copy(dictionary_path, dictionary);
         }
     }

     private void button1_Click(object sender, EventArgs e)
     {
         this.Close();
     }
    }
}
