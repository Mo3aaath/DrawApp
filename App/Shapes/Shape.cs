using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Shapes
{
    public abstract class Shape 
    {
        protected int x;
        protected int y;
        protected bool selected = false;
        protected int id;

        public Shape() 
        {
        }

        public abstract void Draw(Graphics g);

        public abstract void Highlight(Graphics g);

        public abstract PointF[] GetPoints();

        public abstract String GetInfo();
        
        public abstract bool ContainsClick(Point mousePoint);

        public bool isSelected()
        {
            return selected;
        }

        public void setSelect(bool select)
        {
            this.selected = select;
        }




    }


}
