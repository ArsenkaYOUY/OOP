﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using GraphicalEditor.Services;

namespace GraphicalEditor.Controllers
{
    public class DrawingSettingsController
    {
        public DrawingSettings Settings { get; } = new DrawingSettings();

        public void UpdateStrokeColor(Color color) => Settings.StrokeColor = color;
        public void UpdateFillColor(Color color) => Settings.FillColor = color;
        public void UpdateStrokeThickness(double thickness) => Settings.StrokeThickness = thickness;
    }
}
