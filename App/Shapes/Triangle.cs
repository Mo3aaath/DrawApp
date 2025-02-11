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
    public class Triangle : Shape
    {
        private int width;
        private int height;
        private static int triNum = 0;

        public Triangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            triNum++;
            this.id = triNum;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            using (g)
            {
                g.DrawPolygon(p, this.GetPoints());
            }
        }

        public override void Highlight(Graphics g)
        {
            Pen p = new Pen(Color.Red);
            using (g)
            {
                g.DrawPolygon(p, this.GetPoints());
            }
        }

        public override PointF[] GetPoints()
        {
            Point p1 = new Point((2*x + width) / 2, y);
            Point p2 = new Point(x, y + height);
            Point p3 = new Point(x + width, y + height);

            PointF[] points = new PointF[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            

            return points;
        }

        public override bool ContainsClick(Point mousePoint)
        {
            PointF[] pts = GetPoints();
            int mouseX = mousePoint.X;
            int mouseY = mousePoint.Y;

            return ((mouseX > pts[1].X & mouseX < pts[2].X)
                    & (mouseY > pts[0].Y & mouseY < pts[2].Y));
        }


        public override string ToString()
        {
            return "Triangle " + id;
        }

        public override String GetInfo()
        {
            return this.ToString() + " (x=" + x + ", y=" + y + ", Width=" + width + ", Height=" + height + ")";
        }
    }
}
