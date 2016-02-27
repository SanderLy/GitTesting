namespace Shiritori
{
    partial class ClientGame
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lblroundNo = new System.Windows.Forms.Label();
            this.lblround = new System.Windows.Forms.Label();
            this.lblpword = new System.Windows.Forms.Label();
            this.lblprev = new System.Windows.Forms.Label();
            this.p2_score = new System.Windows.Forms.Label();
            this.deadtimer = new System.Windows.Forms.Timer(this.components);
            this.deadclock = new System.Windows.Forms.ProgressBar();
            this.p1_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.btnSaveIP = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Player 2:";
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Location = new System.Drawing.Point(24, 258);
            this.lblp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(68, 19);
            this.lblp1.TabIndex = 36;
            this.lblp1.Text = "Player 1:";
            // 
            // lblroundNo
            // 
            this.lblroundNo.AutoSize = true;
            this.lblroundNo.Location = new System.Drawing.Point(350, 49);
            this.lblroundNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblroundNo.Name = "lblroundNo";
            this.lblroundNo.Size = new System.Drawing.Size(17, 19);
            this.lblroundNo.TabIndex = 35;
            this.lblroundNo.Text = "1";
            this.lblroundNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.Location = new System.Drawing.Point(334, 30);
            this.lblround.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(54, 19);
            this.lblround.TabIndex = 34;
            this.lblround.Text = "Round";
            // 
            // lblpword
            // 
            this.lblpword.AutoSize = true;
            this.lblpword.Location = new System.Drawing.Point(707, 37);
            this.lblpword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpword.Name = "lblpword";
            this.lblpword.Size = new System.Drawing.Size(33, 19);
            this.lblpword.TabIndex = 33;
            this.lblpword.Text = "n/a";
            this.lblpword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpword.TextChanged += new System.EventHandler(this.lblpword_TextChanged);
            // 
            // lblprev
            // 
            this.lblprev.AutoSize = true;
            this.lblprev.Location = new System.Drawing.Point(657, 9);
            this.lblprev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprev.Name = "lblprev";
            this.lblprev.Size = new System.Drawing.Size(114, 19);
            this.lblprev.TabIndex = 32;
            this.lblprev.Text = "Previous Word:";
            // 
            // p2_score
            // 
            this.p2_score.AutoSize = true;
            this.p2_score.Location = new System.Drawing.Point(672, 285);
            this.p2_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p2_score.Name = "p2_score";
            this.p2_score.Size = new System.Drawing.Size(81, 19);
            this.p2_score.TabIndex = 30;
            this.p2_score.Text = "000000000";
            // 
            // deadtimer
            // 
            this.deadtimer.Interval = 1000;
            // 
            // deadclock
            // 
            this.deadclock.Location = new System.Drawing.Point(17, 374);
            this.deadclock.Margin = new System.Windows.Forms.Padding(4);
            this.deadclock.Name = "deadclock";
            this.deadclock.Size = new System.Drawing.Size(754, 36);
            this.deadclock.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.deadclock.TabIndex = 31;
            this.deadclock.Value = 100;
            // 
            // p1_score
            // 
            this.p1_score.AutoSize = true;
            this.p1_score.Location = new System.Drawing.Point(23, 285);
            this.p1_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p1_score.Name = "p1_score";
            this.p1_score.Size = new System.Drawing.Size(81, 19);
            this.p1_score.TabIndex = 29;
            this.p1_score.Text = "000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter word:";
            // 
            // txtword
            // 
            this.txtword.Enabled = false;
            this.txtword.Location = new System.Drawing.Point(17, 133);
            this.txtword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(764, 27);
            this.txtword.TabIndex = 27;
            // 
            // btnSaveIP
            // 
            this.btnSaveIP.Location = new System.Drawing.Point(244, 473);
            this.btnSaveIP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveIP.Name = "btnSaveIP";
            this.btnSaveIP.Size = new System.Drawing.Size(100, 34);
            this.btnSaveIP.TabIndex = 26;
            this.btnSaveIP.Text = "Save";
            this.btnSaveIP.UseVisualStyleBackColor = true;
            this.btnSaveIP.Click += new System.EventHandler(this.btnSaveIP_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(17, 476);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(217, 27);
            this.txtIP.TabIndex = 25;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(271, 170);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(190, 59);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ClientGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.lblroundNo);
            this.Controls.Add(this.lblround);
            this.Controls.Add(this.lblpword);
            this.Controls.Add(this.lblprev);
            this.Controls.Add(this.p2_score);
            this.Controls.Add(this.deadclock);
            this.Controls.Add(this.p1_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.btnSaveIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientGame";
            this.Text = "ClientGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientGame_FormClosed);
            this.Load += new System.EventHandler(this.ClientGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Label lblroundNo;
        private System.Windows.Forms.Label lblround;
        public System.Windows.Forms.Label lblpword;
        private System.Windows.Forms.Label lblprev;
        private System.Windows.Forms.Label p2_score;
        private System.Windows.Forms.Timer deadtimer;
        private System.Windows.Forms.ProgressBar deadclock;
        private System.Windows.Forms.Label p1_score;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Button btnSaveIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnOk;

    }
}