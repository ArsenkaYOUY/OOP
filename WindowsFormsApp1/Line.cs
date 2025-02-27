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
}
