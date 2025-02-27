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

        public PolygonShape(Point[] points, Color color, float width) : base(color, width)
        {
            this.points = points;
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(pen, points);
        }
    }
}
