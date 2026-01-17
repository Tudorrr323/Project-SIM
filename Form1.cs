using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace Counter_Strike_Nexon_Zombies_2D
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100, speed = 10, ammo = 20, zombieSpeed = 3, score;
        Random randNum = new Random();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundCorner(
                int leftRect,
                int topRect,
                int rightRect,
                int bottomRect,
                int widthEllipse,
                int heightEllipse
            );
        int counter = 0, len = 0;
        string text;

        List<PictureBox> zombiesList = new List<PictureBox>();
        List<PictureBox> medkitList = new List<PictureBox>();
        List<PictureBox> ammoList = new List<PictureBox>();

        public static SoundPlayer shoot = new SoundPlayer(Application.StartupPath + "\\Resources\\SHOOT.wav");
        public static SoundPlayer collect = new SoundPlayer(Application.StartupPath + "\\Resources\\PICKUP.wav");
        public static SoundPlayer menuMusic = new SoundPlayer(Application.StartupPath + "\\Resources\\Eye of the Tiger.wav");
        public static SoundPlayer medkit = new SoundPlayer(Application.StartupPath + "\\Resources\\MedPickup.wav");
        public static SoundPlayer hurt = new SoundPlayer(Application.StartupPath + "\\Resources\\HURT.wav");

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 7, 7));
            player.Hide();
            menuMusic.Play();
            nextLevel.Hide();
        }

        private void startGame(object sender, EventArgs e)
        {
            beginGame.Hide();
            text = storyText.Text;
            len = text.Length;
            storyText.Text = "";
            timer1.Start();
            storyText.Visible = true;
            zombieStory.Visible = true;
            start.Hide();
        }

        private void restartGameBtn(object sender, EventArgs e)
        {
            RestartGame(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            storyText.Text = text.Substring(0, counter);
            ++counter;

            if(counter > len)
            {
                beginGame.Show();
                timer1.Stop();
            }
        }

        private void beginGame_Click(object sender, EventArgs e)
        {
            menuMusic.Stop();
            RestartGame();
            txtAmmo.Visible = true;
            txtScore.Visible = true;
            txtHealth.Visible = true;
            healthBar.Visible = true;
            player.Visible = true;
            start.Visible = false;
            storyText.Visible = false;
            beginGame.Visible = false;
            zombieStory.Visible = false;
            player.Show();
            icon.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DeleteZombies()
        {
            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }
            zombiesList.Clear();
        }

        private void DeleteMedkit()
        {
            foreach (PictureBox i in medkitList)
            {
                this.Controls.Remove(i);
            }
            medkitList.Clear();
        }

        private void nextLevel_Click(object sender, EventArgs e)
        {
            
            txtAmmo.Visible = false;
            txtHealth.Visible = false;
            healthBar.Visible = false;
            txtScore.Visible = false;
            nextLevel.Visible = false;
            storyText.Text = "To be continued";
            storyText.Visible = true;
            DeleteAmmo();
            DeleteMedkit();
            menuMusic.Play();
        }

        private void DeleteAmmo()
        {
            foreach (PictureBox i in ammoList)
            {
                this.Controls.Remove(i);
            }
            ammoList.Clear();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                healthBar.Value = 0;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            if (healthBar.Value == 0)
                pressRestart.Visible = true;

            if(score == 25)
            {
                DeleteZombies();
                goUp = false;
                goDown = false;
                goLeft = false;
                goRight = false;
                nextLevel.Show();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score + " / 25";

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 52)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }


            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                    ammo += 10;
                    collect.Play();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "medkit")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        playerHealth += 100 - playerHealth;
                        medkit.Play();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                        hurt.Play();
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }


            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                shoot.Play();
                ammo--;
                ShootBullet(facing);


                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (gameOver == false && playerHealth < 50 && medkitList.Count < 1)
            {
                DropMedkit();
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.BackColor = System.Drawing.Color.Transparent;
            zombie.Left = randNum.Next(0, 1000);
            zombie.Top = randNum.Next(0, 1000);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.BackColor = System.Drawing.Color.Transparent;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            ammoList.Add(ammo);
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();

        }

        private void DropMedkit()
        {
            PictureBox medkit = new PictureBox();
            medkit.Image = Properties.Resources.medkit;
            medkit.BackColor = System.Drawing.Color.Transparent;
            medkit.SizeMode = PictureBoxSizeMode.AutoSize;
            medkit.Left = randNum.Next(10, this.ClientSize.Width - medkit.Width);
            medkit.Top = randNum.Next(60, this.ClientSize.Height - medkit.Height);
            medkit.Tag = "medkit";
            medkitList.Add(medkit);
            this.Controls.Add(medkit);

            medkit.BringToFront();
            player.BringToFront();
        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            DeleteZombies();
            DeleteMedkit();
            DeleteAmmo();

            for (int i = 0; i < 5; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 20;

            pressRestart.Visible = false;

            GameTimer.Start();

        }

    }
}
