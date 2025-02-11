using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Shapes;
namespace App
{
    public partial class InfoMode : Form
    {
        public InfoMode()
        {
            InitializeComponent();
        }

        int listLength = 0;


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            List<Shape> shapes = DrawMode.GetShapes();

            if (shapes.Count != listLength)
            {
                infoList.Items.Clear();
                
                foreach (Shape shape in shapes)
                {
                    var item = infoList.Items.Add(shape.GetInfo());
                }

                listLength = shapes.Count;
            }
        }


        private void drawModeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
