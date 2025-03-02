using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class PolylineShape : Shape
    {
        public Point[] points { get; set; }
        public PolylineShape() { }
        public PolylineShape(Color color, float width) : base(color, width) { }
        public override void Draw(Point p, Graphics g)
        {
            this.points = new Point[] { new Point(p.X, p.Y), new Point(p.X + 20, p.Y - 20), new Point(p.X + 35, p.Y + 10), new Point(p.X + 15, p.Y + 10), new Point (p.X + 35, p.Y + 35) };
            Pen pen = new Pen(Color, Width);
            g.DrawLines(pen, this.points);
        }

        
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, Width);
            g.DrawLines(pen, this.points);
        }
    }
}
