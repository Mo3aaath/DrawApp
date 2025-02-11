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
    public class Rect : Shape
    {
        private int width;
        private int height;
        private static int rectNum = 0;
        public Rect(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            rectNum++;
            this.id = rectNum;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            using (g)
            {
                g.DrawRectangle(p, x, y, width, height);
            }
        }

        public override void Highlight(Graphics g)
        {
            
            Pen p = new Pen(Color.Red);
            using (g)
            {
                g.DrawRectangle(p, x, y, width, height);
            }
        }

        public override PointF[] GetPoints()
        {
            Point p1 = new Point(x, y);
            Point p2 = new Point(x + width, y);
            Point p3 = new Point(x, y + height);
            Point p4 = new Point(x + width, y + height);

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
            return "Rectangle " + id;
        }

        public override String GetInfo()
        {
            return this.ToString() + " (x=" + x + ", y=" + y + ", Width=" + width + ", Height=" + height + ")";
        }
    }
}
