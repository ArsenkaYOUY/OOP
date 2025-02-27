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
    public abstract class Shape
    {
        protected Pen pen;

        public Shape(Color color, float width)
        {
            pen = new Pen(color, width);
        }

        public abstract void Draw(Graphics e);

        public virtual void Dispose()
        {
            pen.Dispose();
        }
    }

    public class Line : Shape
    {
        private Point start, end;

        public Line(Point start, Point end, Color color, float width) : base(color, width)
        {
            this.start = start;
            this.end = end;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, start, end);
        }
    }

    public class RectangleShape : Shape
    {
        private Rectangle rect;

        public RectangleShape(Rectangle rect, Color color, float width) : base (color, width)
        {
            this.rect = rect;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rect);
        }
    }

    public class EllipseShape : Shape
    {
        private Rectangle rect;

        public EllipseShape(Rectangle rect, Color color, float width) : base(color, width)
        {
            this.rect = rect;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, rect);
        }
    }
    public class PolygonShape : Shape
    {
        private Point[] points;

        public PolygonShape(Point[] points, Color color, float width) : base(color, width)
        {
            this.points = points;
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(pen, points);
        }
    }

    public class PolylineShape : Shape
    {
        private Point[] points;

        public PolylineShape(Point[] points, Color color, float width) : base(color, width)
        {
            this.points = points;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLines(pen, points);
        }
    }



    public partial class Form1: Form
    {
        private List<Shape> shapes;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 500);
            this.Text = "Hello world";
            this.Paint += new PaintEventHandler(Form1_Paint); // Подписываемся на событие Paint
            shapes = new List<Shape>
        {
            new Line(new Point(50, 50), new Point(200, 50), Color.Black, 2),
            new RectangleShape(new Rectangle(50, 70, 100, 50), Color.Blue, 2),
            new EllipseShape(new Rectangle(50, 130, 100, 50), Color.Red, 2),
            new PolygonShape(new Point[] { new Point(50, 200), new Point(20, 250), new Point(80, 250) }, Color.Green, 2),
            new PolylineShape(new Point[] { new Point(150, 200), new Point(200, 220), new Point(180, 250), new Point(220, 280) }, Color.Purple, 2)
        };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics); // Вызываем метод Draw() у всех фигур
            }
        }
    }
}
