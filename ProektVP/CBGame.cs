using ProektVP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektVP
{
    public partial class CBGame : Form
    {
        public int height;
        public int width;
        public BallList balls;
        Timer timerMove;
        Timer timerClick;
        Timer timerStop;
        Timer changeSize;
        Timer changeVelocity;
        int Points;
        Level levels;
        bool level3Povikano;
        bool level5Zabrzano;
        bool level7;
        bool level1;

        public CBGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Points = 0;
            levels = new Level();

            this.balls = new BallList();
            balls.AddBall(new Ball(30, 200, 70, 15, Color.Red));
            height = this.Height;
            width = this.Width;
            this.level3Povikano = true;
            this.level5Zabrzano = true;
            this.level7 = true;
            this.level1 = true;

            timerMove = new Timer();
            timerMove.Interval=70;
            timerMove.Tick += new EventHandler(timerMove_Tick);
            timerMove.Start();

            timerClick = new Timer();
            timerClick.Interval = 70;
            timerClick.Tick += new EventHandler(timerClick_Tick);

            timerStop = new Timer();
            timerStop.Interval = 4000;
            timerStop.Tick += new EventHandler(timerStop_Tick);
            levels.Level1(balls);


            changeSize = new Timer();
            changeSize.Interval = 2000;
            changeSize.Tick += new EventHandler(changeSize_Tick);

            changeVelocity = new Timer();
            changeVelocity.Interval = 2000;
            changeVelocity.Tick += new EventHandler(changeVelocity_Tick);

        }

        private void changeVelocity_Tick(object sender, EventArgs e)
        {
            checkLevel();
            Invalidate(true);
        }

        private void changeSize_Tick(object sender, EventArgs e)
        {
            checkLevel();
            Invalidate(true);
        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            timerClick.Stop();
            timerMove.Start();
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            balls.MoveClick(0, 0, 400, 305);
            if (balls.gameOver(height))
            {
                timerClick.Stop();
                var res = MessageBox.Show("Try again?", "GAME OVER", MessageBoxButtons.YesNo);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Hide();
                    CBMenu cbMenu = new CBMenu();
                    cbMenu.ShowDialog();
                }
                else
                    Application.Exit();
            }
            Invalidate(true);
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (level1)
            {
                level1Info();
                level1 = false;
            }
            balls.MoveBeforeClick(0, 0, width, height);
            if (balls.gameOver(height))
            {
               //timerClick.Stop();
                timerMove.Stop();
                timerStop.Stop();
                changeSize.Stop();
                var res = MessageBox.Show("Try again?", "GAME OVER", MessageBoxButtons.YesNo);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Hide();
                    CBMenu cbMenu = new CBMenu();
                    cbMenu.ShowDialog();
                }
                else
                    Application.Exit();
            }
                
            Invalidate(true);
        }

       
        private void CBGame_Paint(object sender, PaintEventArgs e)
        {
            Image b = Resources.click;
            Rectangle rec = new Rectangle(0,400, 556, 89);
            e.Graphics.DrawImage(b, rec);
            balls.Draw(e.Graphics);
            label1.Text = this.Points.ToString();
            
        }

        public void checkLevel()
        {
            if (Points >= 10 && Points < 20)
            {
                changeSize.Start();
                levels.Level2(balls);
                
            }
             else
             {
                 if (Points >= 20 && Points < 30)
                 {
                     changeSize.Interval = 300;
                    if (level3Povikano)
                    {
                        levels.Level3(balls, true);
                        level3Povikano = false;
                    }
                    levels.Level3(balls, false);
                }
                 else if(Points>=30 && Points < 40)
                 {
                     changeSize.Stop();
                     levels.Level4(balls);
                 }
                 else if(Points>=40 && Points<50)
                {
                     changeVelocity.Start();

                    if (level5Zabrzano)
                    {
                        levels.Level5(balls, this.level5Zabrzano);
                        level5Zabrzano = false;
                    }
                    else
                    {
                         levels.Level5(balls, this.level5Zabrzano);
                         level5Zabrzano = true;
                     }
                 }
                 else if(Points>=50 && Points < 60)
                {
                    changeVelocity.Stop();
                    levels.Level6(balls);
                }
                else if (Points >= 60 && Points < 70)
                {
                    if (level7)
                    {
                        levels.Level7(balls, level7);
                        level7Info();
                        level7 = false;
                    }
                    else
                        levels.Level7(balls, level7);

                }
            }


        }

        private void CBGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (balls.isClickedRed(e.X, e.Y))
            {
                this.Points++;
                timerMove.Stop(); //se dvizi nadolu
                balls.deleteRedClick(e.X, e.Y);
                balls.MoveUp();
                timerClick.Start();
                timerStop.Start();
                checkLevel();
            }
            if (balls.isClickedBlue(e.X, e.Y))
            {
                timerMove.Stop();
                timerStop.Stop();
                timerClick.Stop();
                    var res = MessageBox.Show("Try again?", "GAME OVER", MessageBoxButtons.YesNo);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Hide();
                        CBMenu cbMenu = new CBMenu();
                        cbMenu.ShowDialog();
                    }
                    else
                        Application.Exit();
                 
            }
        }

        private void CBGame_Load(object sender, EventArgs e)
        {

        }
        private void level1Info()
        {
            timerMove.Stop();
            var res = MessageBox.Show("Instructions:\nDon't click on the blue balls", "Level 1 - 7", MessageBoxButtons.OK);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
              
                timerMove.Start();
            }
        }
        private void level7Info()
        {
            timerClick.Stop();
            timerStop.Stop();
            timerMove.Stop();
            var res = MessageBox.Show("Instructions:\nHit the SMALLER red ball", "Level 7", MessageBoxButtons.OK);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                timerMove.Start();
                timerStop.Start();
            }
        }
    }
}
