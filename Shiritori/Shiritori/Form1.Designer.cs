namespace Shiritori
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a_score = new System.Windows.Forms.Label();
            this.deadclock = new System.Windows.Forms.ProgressBar();
            this.deadtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 194);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(16, 148);
            this.txtword.Margin = new System.Windows.Forms.Padding(4);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(475, 27);
            this.txtword.TabIndex = 1;
            this.txtword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter word:";
            // 
            // a_score
            // 
            this.a_score.AutoSize = true;
            this.a_score.Location = new System.Drawing.Point(12, 70);
            this.a_score.Name = "a_score";
            this.a_score.Size = new System.Drawing.Size(81, 19);
            this.a_score.TabIndex = 4;
            this.a_score.Text = "000000000";
            // 
            // deadclock
            // 
            this.deadclock.Location = new System.Drawing.Point(12, 346);
            this.deadclock.Name = "deadclock";
            this.deadclock.Size = new System.Drawing.Size(480, 23);
            this.deadclock.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.deadclock.TabIndex = 5;
            // 
            // deadtimer
            // 
            this.deadtimer.Interval = 1000;
            this.deadtimer.Tick += new System.EventHandler(this.deadtimer_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.deadclock);
            this.Controls.Add(this.a_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGame";
            this.Text = "The Beginning of The End";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGame_FormClosed);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a_score;
        private System.Windows.Forms.ProgressBar deadclock;
        private System.Windows.Forms.Timer deadtimer;
    }
}

