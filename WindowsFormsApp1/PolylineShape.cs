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
            pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            
            g.DrawLines(pen, points);
        }
    }
}
