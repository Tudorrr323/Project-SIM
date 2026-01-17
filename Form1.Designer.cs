namespace Counter_Strike_Nexon_Zombies_2D
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.pressRestart = new System.Windows.Forms.Label();
            this.storyText = new System.Windows.Forms.Label();
            this.beginGame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zombieStory = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.nextLevel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombieStory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(12, 12);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(93, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            this.txtAmmo.Visible = false;
            // 
            // txtHealth
            // 
            this.txtHealth.BackColor = System.Drawing.Color.Transparent;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.ForeColor = System.Drawing.Color.White;
            this.txtHealth.Location = new System.Drawing.Point(668, 11);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(80, 24);
            this.txtHealth.TabIndex = 2;
            this.txtHealth.Text = "Health";
            this.txtHealth.Visible = false;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(750, 12);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(222, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            this.healthBar.Visible = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Counter_Strike_Nexon_Zombies_2D.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(470, 416);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(410, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 24);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Kills: 0";
            this.txtScore.Visible = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(440, 565);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(146, 94);
            this.start.TabIndex = 6;
            this.start.Text = "Start Game";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start.Click += new System.EventHandler(this.startGame);
            // 
            // pressRestart
            // 
            this.pressRestart.BackColor = System.Drawing.Color.Transparent;
            this.pressRestart.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pressRestart.Location = new System.Drawing.Point(430, 73);
            this.pressRestart.Name = "pressRestart";
            this.pressRestart.Size = new System.Drawing.Size(156, 238);
            this.pressRestart.TabIndex = 7;
            this.pressRestart.Text = "You\'ve died Press the Enter key to restart game";
            this.pressRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressRestart.Visible = false;
            this.pressRestart.Click += new System.EventHandler(this.restartGameBtn);
            // 
            // storyText
            // 
            this.storyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storyText.BackColor = System.Drawing.Color.Black;
            this.storyText.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyText.ForeColor = System.Drawing.Color.Transparent;
            this.storyText.Location = new System.Drawing.Point(12, 320);
            this.storyText.Margin = new System.Windows.Forms.Padding(1000);
            this.storyText.Name = "storyText";
            this.storyText.Size = new System.Drawing.Size(813, 352);
            this.storyText.TabIndex = 8;
            this.storyText.Text = resources.GetString("storyText.Text");
            this.storyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storyText.Visible = false;
            // 
            // beginGame
            // 
            this.beginGame.BackColor = System.Drawing.Color.Transparent;
            this.beginGame.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.beginGame.Location = new System.Drawing.Point(847, 764);
            this.beginGame.Name = "beginGame";
            this.beginGame.Size = new System.Drawing.Size(131, 45);
            this.beginGame.TabIndex = 9;
            this.beginGame.Text = "Begin";
            this.beginGame.Visible = false;
            this.beginGame.Click += new System.EventHandler(this.beginGame_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zombieStory
            // 
            this.zombieStory.BackColor = System.Drawing.Color.Transparent;
            this.zombieStory.Image = global::Counter_Strike_Nexon_Zombies_2D.Properties.Resources.zleft;
            this.zombieStory.Location = new System.Drawing.Point(862, 455);
            this.zombieStory.Name = "zombieStory";
            this.zombieStory.Size = new System.Drawing.Size(100, 71);
            this.zombieStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.zombieStory.TabIndex = 10;
            this.zombieStory.TabStop = false;
            // 
            // nextLevel
            // 
            this.nextLevel.AutoSize = true;
            this.nextLevel.BackColor = System.Drawing.Color.Transparent;
            this.nextLevel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLevel.ForeColor = System.Drawing.Color.Transparent;
            this.nextLevel.Location = new System.Drawing.Point(813, 883);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(165, 33);
            this.nextLevel.TabIndex = 11;
            this.nextLevel.Text = "Next Level";
            this.nextLevel.Click += new System.EventHandler(this.nextLevel_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Image = global::Counter_Strike_Nexon_Zombies_2D.Properties.Resources.ICON;
            this.icon.Location = new System.Drawing.Point(410, 63);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(142, 171);
            this.icon.TabIndex = 12;
            this.icon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Counter_Strike_Nexon_Zombies_2D.Properties.Resources.pixil_frame_0_15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.nextLevel);
            this.Controls.Add(this.zombieStory);
            this.Controls.Add(this.beginGame);
            this.Controls.Add(this.storyText);
            this.Controls.Add(this.pressRestart);
            this.Controls.Add(this.start);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Counter Strike Nexon Zombies 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombieStory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label pressRestart;
        private System.Windows.Forms.Label storyText;
        private System.Windows.Forms.Label beginGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox zombieStory;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label nextLevel;
        private System.Windows.Forms.PictureBox icon;
    }
}

