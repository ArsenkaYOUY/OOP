using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EllipseShape : Shape
    {
        private Rectangle rect;

        public EllipseShape(Color color, float width) : base(color, width)
        {
            pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            this.rect = new Rectangle(p.X - 30, p.Y - 30, 60, 60);
            g.DrawEllipse(pen, rect);
        }
    }
}
