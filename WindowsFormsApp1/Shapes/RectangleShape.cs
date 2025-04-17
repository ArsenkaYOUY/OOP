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
        public Rectangle Rect { get; set; }
        public SerializableColor FillColor { get; set; }

        public RectangleShape() { }

        public RectangleShape( Color color, float width, Color fillColor) : base(color, width)
        {
            FillColor = new SerializableColor(fillColor);
        }

        public override void Draw(Point p, Graphics g)
        {
            this.Rect = new Rectangle(p.X - 25, p.Y - 25, 50, 50);
            Pen pen = new Pen(Color.ToColor(), Width);
            g.DrawRectangle(pen, this.Rect);
            Brush brush = new SolidBrush(FillColor.ToColor());
            g.FillRectangle(brush, this.Rect);
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.ToColor(), Width);
            g.DrawRectangle(pen, this.Rect);
            Brush brush = new SolidBrush(FillColor.ToColor());
            g.FillRectangle(brush, this.Rect);
        }
    }
}
