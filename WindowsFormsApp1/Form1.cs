using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Shape selectedShape;
        private Point p = new Point();

        private List<Shape> shapes;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 500);
            this.Text = "Hello world";
            shapes = new List<Shape> { };

        }

        private void bttnRectangle_Click(object sender, EventArgs e)
        {
            selectedShape = new RectangleShape( Color.Blue, 2);

        }

        private void bbtnLine_Click(object sender, EventArgs e)
        {
            selectedShape = new Line(Color.Black, 2);
        }

        private void bttnEllipse_Click(object sender, EventArgs e)
        {
            selectedShape = new EllipseShape( Color.Red, 2);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void bttnPolygon_Click(object sender, EventArgs e)
        {
            selectedShape = new PolygonShape(Color.Green, 2);
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedShape != null)
            {
                p.X = e.X;
                p.Y = e.Y;
                Graphics paint;
                paint = panel1.CreateGraphics();
                shapes.Add(selectedShape);
                selectedShape.Draw(p, paint);
                selectedShape = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            Graphics paint;
            paint = panel1.CreateGraphics();
            paint.Clear(Color.White);

            if (shapes.Count > 0 )
            {
                int ind = shapes.Count - 1;
                shapes.RemoveAt(ind);

                int i = 0;
                if (shapes != null)
                {
                    while (i <= shapes.Count - 1)
                    {
                        var shapee = shapes.ElementAt(i);
                        shapee.Draw(paint);

                        i++;
                    }

                }
                
            }
        }

        private void bttnForward_Click(object sender, EventArgs e)
        {

           
        }

        private void bttnPolylines_Click(object sender, EventArgs e)
        {

            selectedShape = new PolylineShape(Color.Green, 2);
        }
    }
}
