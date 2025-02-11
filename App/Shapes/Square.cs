using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Shapes
{
    public class Square : Shape 
    {
        private int side;
        private static int squareNum = 0;
        public Square(int x, int y, int side) 
        {
            this.x = x;
            this.y = y;
            this.side = side;
            squareNum++;
            this.id = squareNum;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            using(g)
            {
                g.DrawRectangle(p, x, y, side, side);
            }
        
        }

        public override void Highlight(Graphics g)
        {

           
            Pen p = new Pen(Color.Red);
            using (g)
            {
                g.DrawRectangle(p, x, y, side, side);
            }
        }

        public override PointF[] GetPoints()
        {
            Point p1 = new Point(x, y);
            Point p2 = new Point(x + side, y);
            Point p3 = new Point(x, y + side);
            Point p4 = new Point(x + side, y + side);

            PointF[] points = new PointF[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;

            return points;
        }

        public override bool ContainsClick(Point mousePoint)
        {
            PointF[] pts = GetPoints();
            int mouseX = mousePoint.X;
            int mouseY = mousePoint.Y;

            return ((mouseX > pts[0].X & mouseX < pts[1].X)
                    & (mouseY > pts[0].Y & mouseY < pts[2].Y));
        }


        public override string ToString()
        {
            return "Square " + id; 
        }

        public override String GetInfo()
        {
            return this.ToString() + " (x=" + x + ", y=" + y + ", Side=" + side + ")";
        }
    }
}
