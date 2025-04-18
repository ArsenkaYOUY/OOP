﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class PolygonShape : Shape
    {
        public Point[] points { get; set; }
        public SerializableColor FillColor { get; set; }

        public PolygonShape() { }
        public PolygonShape(Color color, float width, Color fillColor) : base(color, width) 
        {
            FillColor = new SerializableColor(fillColor);
        }

        public override void Draw(Point p, Graphics g)
        {
            this.points = new Point[] { new Point(p.X - 30,p.Y), new Point(p.X + 30, p.Y), new Point(p.X , p.Y - 30) };

            Pen pen = new Pen(Color.ToColor(), Width);
            g.DrawPolygon(pen, this.points);
            Brush brush = new SolidBrush(FillColor.ToColor());
            g.FillPolygon(brush,this.points);
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.ToColor(), Width);
            g.DrawPolygon(pen, this.points);
            Brush brush = new SolidBrush(FillColor.ToColor());
            g.FillPolygon(brush, this.points);
        }
    }
}
