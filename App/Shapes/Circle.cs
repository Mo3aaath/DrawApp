using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace App.Shapes
{
    public class Circle : Shape
    {
        private int radius;
        private static int circleNum;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            circleNum++;
            this.id = circleNum;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            using (g)
            {
                g.DrawEllipse(p, x, y, radius, radius);
            }
        }

        public override void Highlight(Graphics g)
        {
            
            Pen p = new Pen(Color.Red);
            using (g)
            {
                g.DrawEllipse(p, x, y, radius, radius);
            }
        }



        public override string ToString()
        {
            return "Circle " + id;
        }

        public override PointF[] GetPoints()
        {
            Point p1 = new Point(x, y);
            Point p2 = new Point(x + radius, y);
            Point p3 = new Point(x, y + radius);
            Point p4 = new Point(x + radius, y + radius);

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

        public override String GetInfo()
        {
            return this.ToString() + " (x=" + x + ", y=" + y + ", Radius=" + radius +")";
        }
    }
}
