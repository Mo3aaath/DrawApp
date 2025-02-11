using App.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class DrawMode : Form
    {
        private static List<Shape> myShapes = new List<Shape>();
        private List<Label> myLabels = new List<Label>();

        public static List<Shape> GetShapes()
        {
            return myShapes;
        }

        public DrawMode()
        {
            InitializeComponent();
        }



        private void lineBt_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, 900);
            int y = rand.Next(0, 500);
            int x2 = rand.Next(10, 500);
            int y2 = y + rand.Next(10, 350);

            Shape s = new Line(x, y, x2, y2);
            Graphics g = drawingPanel.CreateGraphics();

            s.Draw(g);
            myShapes.Add(s); 

            Label label = new Label();
            label.Text = s.ToString();
            label.Click += LabelClick;
            myLabels.Add(label);

            nameList.Controls.Add(label);
        }
        
        private void circleBt_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, 900);
            int y = rand.Next(0, 500);
            int radius = rand.Next(10, 350);

            Shape s = new Circle(x, y, radius);
            Graphics g = drawingPanel.CreateGraphics();

            s.Draw(g);
            myShapes.Add(s);

            Label label = new Label();
            label.Text = s.ToString();
            label.Click += LabelClick;
            myLabels.Add(label);

            nameList.Controls.Add(label);

        }
      
        private void rectBt_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, 900);
            int y = rand.Next(0, 500);
            int width = rand.Next(10, 350);
            int height = rand.Next(10, 350);

            Shape s = new Rect(x, y, width, height);
            Graphics g = drawingPanel.CreateGraphics();
            s.Draw(g);

            myShapes.Add(s);

            Label label = new Label();
            label.Text = s.ToString();
            label.Click += LabelClick;

            myLabels.Add(label);

            nameList.Controls.Add(label);
        }

        private void squareBt_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, 900);
            int y = rand.Next(0, 500);
            int side = rand.Next(10, 350);

            Shape s = new Square(x, y, side);
            Graphics g = drawingPanel.CreateGraphics();
            s.Draw(g);

            myShapes.Add(s);

            Label label = new Label();
            label.Text = s.ToString();
            label.Click += LabelClick;

            myLabels.Add(label);

            nameList.Controls.Add(label);


        }

        private void triBt_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, 900);
            int y = rand.Next(0, 500);
            int width = rand.Next(10, 350);
            int height = rand.Next(10, 350);

            Shape s = new Triangle(x, y, width, height);
            Graphics g = drawingPanel.CreateGraphics();
            s.Draw(g);

            myShapes.Add(s);

            Label label = new Label();
            label.Text = s.ToString();
            label.Click += LabelClick;

            myLabels.Add(label);

            nameList.Controls.Add(label);
        }

        // drawing area mouse-click event handler
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Point mousePoint = e.Location;
                CheckCoordinates(mousePoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.StackTrace);
            }

            
        }

        private void CheckCoordinates(Point mousePoint) 
        {
            foreach (Shape s in myShapes)
            {
                // if the shape contains a click and is not selected
                if (s.ContainsClick(mousePoint) & !s.isSelected())
                {
                    s.setSelect(true);
                    HighlightLabel(s.ToString(), Color.AliceBlue);

                    using(Graphics g = drawingPanel.CreateGraphics()) 
                    {
                        s.Highlight(g);
                    }
                    
                } 
                // if the shape contains a click and is selected; nothing happens
                else if (s.ContainsClick(mousePoint) & s.isSelected())
                    continue;

                // if the shape doesn't contain a click, unhighlight it if it's selected
                else 
                {
                    
                    if (s.isSelected())
                    {
                        s.setSelect(false);
                        HighlightLabel(s.ToString(), default);

                        using (Graphics g = drawingPanel.CreateGraphics())
                        {
                            s.Draw(g);
                        }
                    }
                    
                }
                
            }
        }

        // hughlights the shape label
        private void HighlightLabel(String name, Color color)
        {
            foreach (Label item in myLabels)
            {
                if (item.Text == name)
                {
                    item.BackColor = color;
                    break;
                }
            }
        }
       
        

        private void infoModeBtn_Click(object sender, EventArgs e)
        {
            Form frm = new InfoMode();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }


        private void LabelClick(object sender, EventArgs e)
        {
            String text = ((Label)sender).Text;
            
            // highlighting the selected label only
            foreach (Label label in myLabels)
            {
                if (label.Text == text)
                {
                    HighlightLabel(text, Color.AliceBlue);
                }
                else
                {
                    HighlightLabel(label.Text, default);
                }
                
            }

            // highlighting the selected shape only
            foreach (Shape s in myShapes)
            {
                if (s.ToString() == text)
                {
                    s.setSelect(true);

                    using (Graphics g = drawingPanel.CreateGraphics())
                    {
                        s.Highlight(g);
                    }
                }

                else 
                {
                    s.setSelect(false);

                    using (Graphics g = drawingPanel.CreateGraphics())
                    {
                        s.Draw(g);
                    }
                }
            }
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
