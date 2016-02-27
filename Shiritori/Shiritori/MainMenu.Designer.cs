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
            this.btnTPlayer = new System.Windows.Forms.Button();
            this.btnSPlayer = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHow = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.pnlMode = new System.Windows.Forms.Panel();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnLastMan = new System.Windows.Forms.Button();
            this.pnlNet = new System.Windows.Forms.Panel();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHow = new System.Windows.Forms.Panel();
            this.lblHow = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            this.pnlMode.SuspendLayout();
            this.pnlNet.SuspendLayout();
            this.pnlHow.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTPlayer
            // 
            this.btnTPlayer.Location = new System.Drawing.Point(57, 39);
            this.btnTPlayer.Name = "btnTPlayer";
            this.btnTPlayer.Size = new System.Drawing.Size(91, 30);
            this.btnTPlayer.TabIndex = 1;
            this.btnTPlayer.TabStop = false;
            this.btnTPlayer.Text = "Two Player";
            this.btnTPlayer.UseVisualStyleBackColor = true;
            this.btnTPlayer.Click += new System.EventHandler(this.btnTPlayer_Click);
            // 
            // btnSPlayer
            // 
            this.btnSPlayer.Location = new System.Drawing.Point(57, 3);
            this.btnSPlayer.Name = "btnSPlayer";
            this.btnSPlayer.Size = new System.Drawing.Size(91, 30);
            this.btnSPlayer.TabIndex = 2;
            this.btnSPlayer.TabStop = false;
            this.btnSPlayer.Text = "Single Player";
            this.btnSPlayer.UseVisualStyleBackColor = true;
            this.btnSPlayer.Click += new System.EventHandler(this.btnSPlayer_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnQuit);
            this.pnlMenu.Controls.Add(this.btnHow);
            this.pnlMenu.Controls.Add(this.btnPlay);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 96);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(57, 62);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnHow
            // 
            this.btnHow.Location = new System.Drawing.Point(57, 33);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(75, 23);
            this.btnHow.TabIndex = 1;
            this.btnHow.TabStop = false;
            this.btnHow.Text = "How to Play";
            this.btnHow.UseVisualStyleBackColor = true;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(57, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.Controls.Add(this.btnSPlayer);
            this.pnlPlayers.Controls.Add(this.btnTPlayer);
            this.pnlPlayers.Location = new System.Drawing.Point(12, 114);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(200, 96);
            this.pnlPlayers.TabIndex = 3;
            this.pnlPlayers.Visible = false;
            // 
            // pnlMode
            // 
            this.pnlMode.Controls.Add(this.btnHighScore);
            this.pnlMode.Controls.Add(this.btnLastMan);
            this.pnlMode.Location = new System.Drawing.Point(12, 216);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(200, 96);
            this.pnlMode.TabIndex = 3;
            this.pnlMode.Visible = false;
            // 
            // btnHighScore
            // 
            this.btnHighScore.Location = new System.Drawing.Point(25, 13);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(145, 30);
            this.btnHighScore.TabIndex = 2;
            this.btnHighScore.TabStop = false;
            this.btnHighScore.Text = "Highest Scorer";
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnLastMan
            // 
            this.btnLastMan.Location = new System.Drawing.Point(25, 49);
            this.btnLastMan.Name = "btnLastMan";
            this.btnLastMan.Size = new System.Drawing.Size(145, 30);
            this.btnLastMan.TabIndex = 1;
            this.btnLastMan.TabStop = false;
            this.btnLastMan.Text = "Last Man Standing";
            this.btnLastMan.UseVisualStyleBackColor = true;
            this.btnLastMan.Click += new System.EventHandler(this.btnLastMan_Click);
            // 
            // pnlNet
            // 
            this.pnlNet.Controls.Add(this.btnHost);
            this.pnlNet.Controls.Add(this.btnClient);
            this.pnlNet.Location = new System.Drawing.Point(228, 117);
            this.pnlNet.Name = "pnlNet";
            this.pnlNet.Size = new System.Drawing.Size(200, 96);
            this.pnlNet.TabIndex = 4;
            this.pnlNet.Visible = false;
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(37, 37);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(129, 23);
            this.btnHost.TabIndex = 1;
            this.btnHost.TabStop = false;
            this.btnHost.Text = "Play as Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(37, 7);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(129, 23);
            this.btnClient.TabIndex = 0;
            this.btnClient.TabStop = false;
            this.btnClient.Text = "Play as Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(242, 236);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlHow
            // 
            this.pnlHow.Controls.Add(this.lblHow);
            this.pnlHow.Location = new System.Drawing.Point(12, 318);
            this.pnlHow.Name = "pnlHow";
            this.pnlHow.Size = new System.Drawing.Size(200, 100);
            this.pnlHow.TabIndex = 6;
            this.pnlHow.Visible = false;
            // 
            // lblHow
            // 
            this.lblHow.AutoSize = true;
            this.lblHow.Location = new System.Drawing.Point(34, 21);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(64, 13);
            this.lblHow.TabIndex = 0;
            this.lblHow.Text = "How to Play";
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(57, 3);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.TabStop = false;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(57, 33);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.TabStop = false;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(57, 62);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 2;
            this.btnHard.TabStop = false;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.Controls.Add(this.btnHard);
            this.pnlDifficulty.Controls.Add(this.btnMedium);
            this.pnlDifficulty.Controls.Add(this.btnEasy);
            this.pnlDifficulty.Location = new System.Drawing.Point(228, 12);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(200, 96);
            this.pnlDifficulty.TabIndex = 4;
            this.pnlDifficulty.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlHow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlNet);
            this.Controls.Add(this.pnlDifficulty);
            this.Controls.Add(this.pnlMode);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlPlayers.ResumeLayout(false);
            this.pnlMode.ResumeLayout(false);
            this.pnlNet.ResumeLayout(false);
            this.pnlHow.ResumeLayout(false);
            this.pnlHow.PerformLayout();
            this.pnlDifficulty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTPlayer;
        private System.Windows.Forms.Button btnSPlayer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Panel pnlMode;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnLastMan;
        private System.Windows.Forms.Panel pnlNet;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlHow;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Panel pnlDifficulty;
    }
}