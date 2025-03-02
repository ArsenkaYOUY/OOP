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
    public class EllipseShape : Shape
    {
        public Rectangle rect { get; set; }
        public Brush brush { get; set; }

        public EllipseShape() { }

        public EllipseShape(Color color, float width, Color fillColor) : base(color, width)
        {
            //this.brush = new SolidBrush(fillColor);
            //pen = new Pen(color, width);
        }

        public override void Draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color, Width);
            this.rect = new Rectangle(p.X - 30, p.Y - 30, 60, 60);
            g.DrawEllipse(pen, this.rect);
            g.FillEllipse(this.brush, this.rect);
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, Width);
            g.DrawEllipse(pen, this.rect);
            g.FillEllipse(this.brush, this.rect);
        }
    }
}
