using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class MainForm : Form
    {
        private int Step = 1;
        private readonly SnakeGame Game;
        private int NumberOfApples = 1;
        private const int MaxRadius = 2;
        private const int MinRadius = 1;
        int Counter = 0;
        bool pause = false;
        
        public MainForm()
        {
            Form2 d = new Form2();
            d.ShowDialog();
            NumberOfApples = d.applesVal;
            InitializeComponent();
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 10;
            Game = new SnakeGame(new System.Drawing.Point((Field.Width - 20) / 2, Field.Height / 2), 40, NumberOfApples, Field.Size);
            Field.Image = new Bitmap(Field.Width, Field.Height);
            Game.EatAndGrow += Game_EatAndGrow;
            Game.HitWallAndLose += Game_HitWallAndLose;
            Game.HitSnakeAndLose += Game_HitSnakeAndLose;
                    
            

        }

        private void Game_HitWallAndLose()
        {
            SoundPlayer sound = new SoundPlayer("HitWall.wav");
            sound.Play();
            mainTimer.Stop();
            Field.Refresh();
            MessageBox.Show("\tYou Lost!\nNumber of apples eaten: "+ applesEaten);
            
        }
        private void Game_HitSnakeAndLose()
        {
            mainTimer.Stop();
            Field.Refresh();
            SoundPlayer sound = new SoundPlayer("HitSnake.wav");
            sound.Play();
            MessageBox.Show("\tYou Lost!\nNumber of apples eaten: " + applesEaten);
        }

        private void Game_EatAndGrow()
        {
            SoundPlayer sound = new SoundPlayer("EatApple.wav");
            sound.Play();
            applesEaten++;
            if (10 <= applesEaten && applesEaten < 20) 
            {
                Step = 2;
                progressBar1.Value = 2;
            }
            else if(20 <= applesEaten && applesEaten < 30) 
            {
                Step = 3;
                progressBar1.Value = 3;
            }
            else if (30 <= applesEaten && applesEaten < 40)
            {
                Step = 4;
                progressBar1.Value = 4;
            }
            else if (40 <= applesEaten && applesEaten < 50)
            {
                Step = 5;
                progressBar1.Value = 5;
            }
            else if (50 <= applesEaten && applesEaten < 60)
            {
                Step = 6;
                progressBar1.Value = 6;
            }
            else if (60 <= applesEaten && applesEaten < 70)
            {
                Step = 7;
                progressBar1.Value = 7;
            }
            else if (70 <= applesEaten && applesEaten < 80)
            {
                Step = 8;
                progressBar1.Value = 8;
            }
            else if (80 <= applesEaten && applesEaten < 90)
            {
                Step = 9;
                progressBar1.Value = 9;
            }
            else if (90 <= applesEaten)
            {
                Step = 10;
                progressBar1.Value = 10;
            }
            label1.Text = progressBar1.Value.ToString();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

            Game.Move(Step);
            Field.Invalidate();
            Counter++;
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {
            Pen PenForObstacles = new Pen(Color.FromArgb(40,40,40),2);
            Pen PenForSnake = new Pen(Color.FromArgb(100, 100, 100), 2);
            Brush BackGroundBrush = new SolidBrush(Color.FromArgb(150, 250, 150));
            Brush AppleBrush = new SolidBrush(Color.FromArgb(255, 250, 50, 50));
            double Radius = (MaxRadius - MinRadius) * (Math.Sin(Counter * Math.PI / 40.0) + 1) / 2.0 + MinRadius;
            long phase = (Counter / 20) % 4;

            if (phase == 0)

                Radius = (Counter % 80.0 - 20 * phase) * (MaxRadius - MinRadius) / 40.0 + (MaxRadius + MinRadius) / 2.0;
            else if (phase == 1)
                Radius = -(Counter % 80.0 - 20 * phase) * (MaxRadius - MinRadius) / 40.0 + MaxRadius;
            else if (phase == 2)
                Radius = -(Counter % 80.0 - 20 * phase) * (MaxRadius - MinRadius) / 40.0 + (MaxRadius + MinRadius) / 2.0;
            else
                Radius = (Counter % 80.0 - 20 * phase) * (MaxRadius - MinRadius) / 40.0 + MinRadius;

            using (Graphics g = Graphics.FromImage(Field.Image))
            {
                g.FillRectangle(BackGroundBrush,new Rectangle(0,0,Field.Width,Field.Height));
                foreach (Point Apple in Game.Apples)
                    g.FillEllipse(AppleBrush, new Rectangle(Apple.X - (int)Math.Round(Radius),
                                Apple.Y - (int)Math.Round(Radius), 2 * (int)Math.Round(Radius), 2 * (int)Math.Round(Radius)));
                foreach (LineSeg Obstacle in Game.Obstacles)
                    g.DrawLine(PenForObstacles, new System.Drawing.Point(Obstacle.Start.X, Obstacle.Start.Y)
                        , new System.Drawing.Point(Obstacle.End.X, Obstacle.End.Y));
                foreach (LineSeg Body in Game.SnakeBody)
                    g.DrawLine(PenForSnake, new System.Drawing.Point((int)Body.Start.X, (int)Body.Start.Y)
                        , new System.Drawing.Point((int)Body.End.X, (int)Body.End.Y));
            }
        }



        private void Snakes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    Game.Move(Step, Direction.UP);
                    break;
                case Keys.Down:
                    Game.Move(Step, Direction.DOWN);
                    break;
                case Keys.Left:
                    Game.Move(Step, Direction.LEFT);
                    break;
                case Keys.Right:
                    Game.Move(Step, Direction.RIGHT);
                    break;
            }
        }

        private void Field_Click(object sender, EventArgs e)
        {
            if (!mainTimer.Enabled)
            {
                mainTimer.Start();
            }
            else
            {
                mainTimer.Stop();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
