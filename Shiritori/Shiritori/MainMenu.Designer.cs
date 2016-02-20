namespace Shiritori
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mplay = new System.Windows.Forms.Button();
            this.splay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mplay
            // 
            this.mplay.Location = new System.Drawing.Point(133, 190);
            this.mplay.Name = "mplay";
            this.mplay.Size = new System.Drawing.Size(91, 38);
            this.mplay.TabIndex = 1;
            this.mplay.Text = "Multi Player";
            this.mplay.UseVisualStyleBackColor = true;
            this.mplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // splay
            // 
            this.splay.Location = new System.Drawing.Point(133, 59);
            this.splay.Name = "splay";
            this.splay.Size = new System.Drawing.Size(91, 38);
            this.splay.TabIndex = 2;
            this.splay.Text = "Single Player";
            this.splay.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 78);
            this.textBox1.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 342);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splay);
            this.Controls.Add(this.mplay);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mplay;
        private System.Windows.Forms.Button splay;
        private System.Windows.Forms.TextBox textBox1;
    }
}