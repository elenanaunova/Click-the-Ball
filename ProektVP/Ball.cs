using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProektVP
{
    public class Ball
    {
        public int RADIUS { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }
        
        public double Velocity { get; set; }
        public static int[] Angle= { 60, 270 };
        Random r;

        public float velocityX { get; set; }
        public float velocityY { get; set; }


        public Ball(int ra, float x, float y, float v, Color c)
        {
            RADIUS = ra;
            X = x;
            Y = y;
            color = c;
            Velocity = v;

            r = new Random();

            velocityX = (float)(Math.Cos(Angle[r.Next(0, 2)]) * Velocity);
            velocityY = (float)(Math.Sin(Angle[r.Next(0, 2)]) * Velocity);
        }
        public Ball(int ra,int angle,int Velocity,int x,int y,Color c)
        {
            RADIUS = ra;
            velocityX = (float)(Math.Cos(angle) * Velocity);
            velocityY = (float)(Math.Sin(angle) * Velocity);
            X = x;
            Y = y;
            color = c;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, X - RADIUS, Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }

        public void Move(float x, float y, int left, int top, int width, int height)
        {
            if (isClicked(x,y))
            {
                MoveClicked(left, top, width, height);
            }
            else
            {
                if (color == Color.Red)
                    MoveDown(height);
                else
                    MoveClicked(left, top, width, height);
            }
        }

        public bool isClicked(float x, float y)
        {
            return (((X - x) * (X - x) + (Y - y) * (Y - y)) <= RADIUS * RADIUS);
        }
        public void MoveDown(float height)
        {
            if (color == Color.Red && RADIUS!=35)
            {
                Y = Y + 6;
            }
            
        }
        public bool gameOver(float height)
        {
            if (color == Color.Red && Y>305 && RADIUS!=35)
                return true;
            return false;
        }
        public void MoveClicked(int left, int top, int width, int height)
        {
            Random r = new Random();
            
            int nextX = (int)(X + velocityX);
            int nextY = (int)(Y + velocityY);

            if (nextX <= RADIUS || nextX>=width-RADIUS)
            {
                velocityX = -velocityX;
                nextX = (int)(X + velocityX);
            }
            
            if (nextY <= RADIUS)
            {
                velocityY = -velocityY;
                nextY = (int)(this.Y + velocityY);
            }
            if (color != Color.Red || ( color==Color.Red && RADIUS==35))
            {
                if (nextY >= 308)
                {
                    
                    velocityY = -velocityY;
                    nextY = (int)(nextY + velocityY);
                }
            }
            X = nextX;
            Y = nextY;
        }
        public bool touchesRight(Ball b)
        {
            return (((X - b.X) * (X - b.X) + (Y - b.Y) * (Y - b.Y)) <= RADIUS * RADIUS);
        }
        public void MoveUp()
        {
           if(Y-15>RADIUS)
            Y = Y - 15;
           
        }

        public void promeniRadius()
        {
            if (color == Color.Red)
            {
                if (RADIUS == 30)
                    RADIUS = 20;
                else
                    RADIUS = 30;
            }
        }
        public void promeniRadiusPlavo()
        {
            if (color == SystemColors.Highlight)
            {
                RADIUS = 30;
            }
        }
    }
}
