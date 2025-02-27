using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RectangleShape : Shape
    {
        private Rectangle rect;

        public RectangleShape( Color color, float width) : base(color, width)
        {
            pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            this.rect = new Rectangle(p.X - 25, p.Y - 25, 50, 50);
            g.DrawRectangle(pen, rect);
        }
    }
}
