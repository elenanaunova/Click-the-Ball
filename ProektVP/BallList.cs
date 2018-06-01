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
            foreach(Ball b in list)
            {
                b.Draw(g);
            }
        }
        public void Move(float x, float y, int left, int top, int width, int height)
        {
            foreach (Ball b in list)
            {
                b.Move(x, y, left, top, width, height);
            }
        }
        public void AddBall(Ball b)
        {
            list.Add(b);
        }
    }
}
