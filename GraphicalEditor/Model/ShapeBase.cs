﻿using System.Windows;
using System.Windows.Media;
using System.Text.Json.Serialization;

namespace GraphicalEditor.Model.Shapes
{
    public abstract class ShapeBase
    {
        public virtual bool IsMultiClick { get; } = false;
        public Color StrokeColor { get; set; }
        public Color FillColor { get; set; }
        public double StrokeThickness { get; set; }
        public abstract void Draw(DrawingContext dc);
        public abstract void Update(Point point);
        public virtual void FinalizeDrawing(Point point) => Update(point);
        public abstract void Initialize(Point point);
    }
}
