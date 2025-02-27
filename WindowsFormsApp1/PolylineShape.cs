using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
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
}
