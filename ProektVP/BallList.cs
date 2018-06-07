using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProektVP
{
    public class BallList
    {
        public List<Ball> list;
        public BallList()
        {
            this.list = new List<Ball>();
        }
   
        public void Draw(Graphics g)
        {
            foreach (Ball b in list)
            {
                if(b.color==Color.Red)
                    b.Draw(g);
            }
            foreach (Ball b in list)
            {
                if (b.color != Color.Red)
                    b.Draw(g);
            }
        }
        public void MoveBeforeClick(int left, int top, int width, int height)
        {
            foreach (Ball b in list)
            {
                if (b.color == Color.Red &&b.RADIUS!=35)
                {
                    b.MoveDown(height);
                       
                }
                   
                else
                    b.MoveClicked(left, top, width, height);       
            }
        }
        public bool gameOver(int height)
        {
            foreach(Ball b in list)
            {
                if (b.gameOver(height))
                    return true;
            }
            return false;
        }
        public void MoveClick(int left, int top, int width, int height)
        {
            foreach (Ball b in list)
            {
                    b.MoveClicked(left, top, width, height);
            }
                
        }
        public void AddBall(Ball b)
        {
            list.Add(b);
        }
        public bool isClickedRed(int x,int y)
        {
            foreach(Ball b in list)
            {
               if(b.color==Color.Red && b.RADIUS!=35)
                if(b.isClicked(x, y))
                        return true;
            }
            return false;
        }
        public bool isClickedBlue(int x,int y)
        {
            foreach (Ball b in list)
            {
                if (b.isClicked(x, y))
                {
                    if (b.color == SystemColors.Highlight)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public void MoveUp()
        {
            foreach (Ball b in list)
            {
                if (b.color == Color.Red)
                    b.MoveUp();
            }
        }
        public void deleteRedClick(int x,int y)
        {
            for(int i = list.Count - 1; i >= 0; i--)
            {
                Ball b = list.ElementAt(i);
                if (b.color == Color.Red && b.RADIUS!=35)
                {
                    list.Remove(b);
                    list.Add(new Ball(30, x, y, 15, Color.Red));
                }

            }

        }

        public void deleteWrongRed()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Ball b = list.ElementAt(i);
                if (b.color == Color.Red && b.RADIUS == 35)
                    list.Remove(b);
            }
        }

        public void deleteBlue()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Ball b = list.ElementAt(i);
                if (b.color == SystemColors.Highlight)
                    list.Remove(b);
            }
        }

        public Point deleteRed()
        {
            Point k=new Point(0,0);
            for (int i = list.Count - 1; i >= 0; i--)
            {
                
                Ball b = list.ElementAt(i);
                if (b.color == Color.Red && b.RADIUS !=35)
                {
                    k = new Point((int)b.X, (int)b.Y);
                    list.Remove(b);
                }               
            }
            return k;
        }

        public void changeBlue()
        {

            foreach (Ball b in list)
                b.promeniRadiusPlavo();
        }


        public void promeniRadius()
        {
            foreach (Ball b in list)
                b.promeniRadius();
        }
        public void promeniBrzina(bool zabrzaj)
        {
            Point p = deleteRed();
            if (zabrzaj)
            {
                Ball b = new Ball(30, p.X, p.Y, 35, Color.Red);
                list.Add(b);
            }
            else
            {
                Ball b = new Ball(30, p.X, p.Y, 10, Color.Red);
                list.Add(b);
            }
        }
    }
}
