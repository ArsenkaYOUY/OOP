using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class RectangleShape : Shape
    {
        private Rectangle rect { get; set; }
        private Brush brush { get; set; }

        public RectangleShape() { }

        public RectangleShape( Color color, float width, Color fillColor) : base(color, width)
        {
            this.brush = new SolidBrush(fillColor);
            //pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            this.rect = new Rectangle(p.X - 25, p.Y - 25, 50, 50);
            Pen pen = new Pen(Color, Width);
            g.DrawRectangle(pen, this.rect);
            g.FillRectangle(this.brush, this.rect);
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, Width);
            g.DrawRectangle(pen, this.rect);
            g.FillRectangle(this.brush, this.rect);
        }
    }
}
