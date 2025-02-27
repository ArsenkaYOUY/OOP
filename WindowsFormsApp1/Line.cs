using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Line : Shape
    {

        public Line( Color color, float width) : base(color, width)
        {
            pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            g.DrawLine(pen, p.X - 50, p.Y, p.X + 50, p.Y);
        }
    }
}
