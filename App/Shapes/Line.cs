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
    public class Line : Shape
    {
        private int x2;
        private int y2;
        private static int lineNum = 0;
  
        public Line(int x, int y, int x2, int y2)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
            lineNum++;
            this.id = lineNum;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            using(g)
            {
                g.DrawLine(p, x, y, x2, y2);
            }
        }

        public override void Highlight(Graphics g)
        {
            Pen p = new Pen(Color.Red);
            using(g)
            {
                g.DrawLine(p, x, y, x2, y2);
            }
        }


        public override PointF[] GetPoints()
        {
            Point p1 = new Point(x, y);
            Point p2 = new Point(x2, y2);
            

            PointF[] points = new PointF[2];
            points[0] = p1;
            points[1] = p2;

            return points;
        }

        public override bool ContainsClick(Point mousePoint)
        {
            PointF[] pts = GetPoints();
            int mouseX = mousePoint.X;
            int mouseY = mousePoint.Y;

            return (((mouseX > pts[0].X & mouseX < pts[1].X)
                    & (mouseY > pts[0].Y & mouseY < pts[1].Y)) 
                    | ((mouseX < pts[0].X & mouseX > pts[1].X)
                    & (mouseY > pts[0].Y & mouseY < pts[1].Y)));
        }


        public override string ToString()
        {
            return "Line " + id;
        }

        public override String GetInfo()
        {
            return this.ToString() + " (x1=" + x + ", y1=" + y + ", x2=" + x2 + ", y2=" + y2 + ")";
        }
    }
}
