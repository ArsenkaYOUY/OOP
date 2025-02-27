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

        public EllipseShape(Rectangle rect, Color color, float width) : base(color, width)
        {
            this.rect = rect;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, rect);
        }
    }
}
