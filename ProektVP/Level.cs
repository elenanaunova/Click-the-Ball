using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ProektVP
{
    public class Level
    {
        //public BallList ballList;
        Random r;
        public Level()
        {
          //  this.ballList = new BallList();
            r = new Random();
           
        }

        public void removeBlack(BallList ballList)
        {
            for(int i=ballList.list.Count-1; i>=0; i--)
            {
                Ball b = ballList.list.ElementAt(i);
                if (b.color == Color.Black)
                    ballList.list.ElementAt(i);
            }
        }

        public void Level1(BallList ballList)
        {
            
            int x = r.Next(40, 200);
            int y = r.Next(40, 285);
            Ball b1 = new Ball(20, 60, 10, x, y, SystemColors.Highlight);
            Ball b2 = new Ball(20, 270, 15, x, y, SystemColors.Highlight);
            ballList.AddBall(b1);
            ballList.AddBall(b2);
            
        }
        public void Level2(BallList ballList)
        {
            ballList.promeniRadius();
        }
        public void Level3(BallList ballList,bool dodadi)
        {
            if (dodadi)
            {
                int x = r.Next(40, 200);
                int y = r.Next(40, 285);
                Ball b1 = new Ball(20, 60, 20, x, y, SystemColors.Highlight);
                ballList.AddBall(b1);
            }
            
            ballList.promeniRadius();
        }

        public void Level4(BallList ballList)
        {
            Point p=ballList.deleteRed();
            ballList.AddBall(new Ball(25, p.X, p.Y, 20, Color.Red));
        }
        public void Level5(BallList ballList, bool Zabrzano)
        {
           
            ballList.promeniBrzina(Zabrzano);
        }

        public void Level6(BallList ballList)
        {
            Point p=ballList.deleteRed();
            ballList.AddBall(new Ball(30, p.X, p.Y, 20, Color.Red));
            ballList.changeBlue();
        }

        public void Level7(BallList ballList, bool dodadi)
        {
            Point p = ballList.deleteRed();
            ballList.AddBall(new Ball(30, p.X, p.Y, 20, Color.Red));
            int x = r.Next(40, 200);
            int y = r.Next(40, 285);
            if(dodadi)
            ballList.AddBall(new Ball(35, x, y, 20, Color.Red));
        }
    }
}
