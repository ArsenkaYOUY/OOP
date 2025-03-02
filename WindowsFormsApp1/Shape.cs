using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    [JsonDerivedType(typeof(Line), "Line")]
    [JsonDerivedType(typeof(RectangleShape), "Rectangle")]
    [JsonDerivedType(typeof(EllipseShape), "Ellipse")]
    [JsonDerivedType(typeof(PolygonShape), "Polygon")]
    [JsonDerivedType(typeof(PolylineShape), "Polyline")]
    public abstract class Shape
    {
        public Color Color { get; set; }
        public float Width { get; set; }

        public Shape() { }

        public Shape(Color color, float width)
        {
            Color = color;
            Width = width;
        }

        public abstract void Draw(Point p, Graphics e);
        public abstract void Draw( Graphics e);

        //public virtual void Dispose()
        //{
        //    pen.Dispose();
        //}
    }
}
