using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Line : Shape
    {
        public Point point { get ; set; }

        public Line() { }
        public Line(Color color, float width) : base(color, width) { }

        public override void Draw(Point p , Graphics g)
        {
            this.point = p;
            Pen pen = new Pen(Color.ToColor(), Width);
            g.DrawLine(pen, p.X - 50, p.Y, p.X + 50, p.Y);
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.ToColor(), Width);
            g.DrawLine(pen, this.point.X - 50, this.point.Y, this.point.X + 50, this.point.Y);
        }
    }
}
