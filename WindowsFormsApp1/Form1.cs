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

        private Bitmap canvas;
        private Graphics graphics;

        private List<Bitmap> list;
        private int currentStateIndex = -1; // Индекс текущего состояния

        private Stack<Shape> shapesDeleted;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 500);
            this.Text = "Hello world";

            // shapes = new List<Shape>(null) { };
            list = new List<Bitmap> { };
            canvas = new Bitmap(panel1.Width, panel1.Height);
            graphics = Graphics.FromImage(canvas);

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
            selectedShape = new PolygonShape( Color.Green, 2);
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedShape != null)
            {
                p.X = e.X;
                p.Y = e.Y;
                selectedShape.Draw(p, graphics);
                list.Add(canvas);
                panel1.Invalidate();
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, 0, 0);
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
           
        }

        private void bttnForward_Click(object sender, EventArgs e)
        {

           
        }
    }
}
