using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalEditor.Model.Shapes
{
    public static class ShapeFactory
    {
        private static readonly Dictionary<string, Func<ShapeBase>> _factories = new Dictionary<string, Func<ShapeBase>>();
        static ShapeFactory()
        {
            _factories["Line"] = () => new LineShape();
            _factories["Rectangle"] = () => new RectangleShape();
            _factories["Ellipse"] = () => new EllipseShape();
            _factories["Polyline"] = () => new PolylineShape();
            _factories["Polygon"] = () => new PolygonShape();
        }
        public static ShapeBase CreateShape(string shapeType)
        {
            if (_factories.ContainsKey(shapeType))
                return _factories[shapeType]();
            throw new ArgumentException("Unknown shape type", nameof(shapeType));
        }
        public static void RegisterShape(string shapeType, Func<ShapeBase> factoryMethod)
        {
            if (!_factories.ContainsKey(shapeType))
                _factories.Add(shapeType, factoryMethod);
        }
    }
}
