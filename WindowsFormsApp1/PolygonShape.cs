using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PolygonShape : Shape
    {
        private Point[] points;
        private Brush brush;

        public PolygonShape( Color color, float width, Color fillColor) : base(color, width)
        {
            this.brush = new SolidBrush(fillColor);
            pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            this.points = new Point[] { new Point(p.X - 30,p.Y), new Point(p.X + 30, p.Y), new Point(p.X , p.Y - 30) };

            g.DrawPolygon(pen, this.points);
            g.FillPolygon(this.brush,this.points);
        }
        public override void Draw(Graphics g)
        {
            g.DrawPolygon(pen, this.points);
            g.FillPolygon(this.brush, this.points);
        }
    }
}
