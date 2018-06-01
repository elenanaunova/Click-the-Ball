using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Ball
    {
        public int RADIUS { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }

        public double Angle { get; set; }
        public double Velocity { get; set; }

        public float velocityX { get; set; }
        public float velocityY { get; set; }

        public Ball(int ra, float x, float y, Color c)
        {
            RADIUS = ra;
            X = x;
            Y = y;
            color = c;

            Velocity = 20;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);
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
                    MoveDown(height, x, y);
                else
                    MoveClicked(left, top, width, height);
            }
        }

        public bool isClicked(float x, float y)
        {
            return (((X - x) * (X - x) + (Y - y) * (Y - y)) <= RADIUS * RADIUS && color==Color.Red);
        }

        public void MoveDown(float height, float x, float y)
        {
            if (color == Color.Red && !isClicked(x,y))
            {
                Y = Y - 20;
            }
        }

        public void MoveClicked(int left, int top, int width, int height)
        {
            int nextX = (int)(X + velocityX);
            int nextY = (int)(Y + velocityY);
            int lft = left + RADIUS;
            int rgt = left + width - RADIUS;
            int tp = top + RADIUS;
            int btm = top + height - RADIUS;

            if (nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityX;
            }
            if (nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityX;

            }
            if (nextY <= tp)
            {
                nextY = tp + (tp - nextY);
                velocityY = -velocityY;
            }
            if (color != Color.Red)
            {
                if (nextY >= btm)
                {
                    nextY = btm - (nextY - btm);
                    velocityY = -velocityY;
                }
            }
            X = nextX;
            Y = nextY;
        }
    }
}
