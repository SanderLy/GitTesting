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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.pnlMode = new System.Windows.Forms.Panel();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnLastMan = new System.Windows.Forms.Button();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            this.pnlMode.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnPlay);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 96);
            this.pnlMenu.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "How to Play";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.Controls.Add(this.btnSPlayer);
            this.pnlPlayers.Controls.Add(this.btnTPlayer);
            this.pnlPlayers.Location = new System.Drawing.Point(12, 114);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(200, 96);
            this.pnlPlayers.TabIndex = 3;
            // 
            // pnlMode
            // 
            this.pnlMode.Controls.Add(this.btnHighScore);
            this.pnlMode.Controls.Add(this.btnLastMan);
            this.pnlMode.Location = new System.Drawing.Point(12, 216);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(200, 96);
            this.pnlMode.TabIndex = 3;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHost);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Location = new System.Drawing.Point(228, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 96);
            this.panel1.TabIndex = 4;
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
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDifficulty);
            this.Controls.Add(this.pnlMode);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlPlayers.ResumeLayout(false);
            this.pnlMode.ResumeLayout(false);
            this.pnlDifficulty.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTPlayer;
        private System.Windows.Forms.Button btnSPlayer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Panel pnlMode;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnLastMan;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnClient;
    }
}