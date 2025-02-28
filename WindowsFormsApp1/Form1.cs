using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Shape selectedShape;
        private Point p = new Point();
        private float lineWidth = 2;
        private Color lineColor = Color.Red;
        private Color fillColor = Color.Red;

        private List<Shape> shapes;
        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape> { };

        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            // Смотреть, на какой кнопке стоит фокус (через свич button.focused) 
            // в зависимости от активности кнопки выделять память под объект нужной фигуры.
            // Обработчик нажатия на кнопку не нужен

            if (bttnLine.Focused)
            { 
                selectedShape = new Line(lineColor, lineWidth);
            }
            else if (bttnPolygon.Focused)
            {
                selectedShape = new PolygonShape(lineColor, lineWidth,fillColor);
            }
            else if (bttnPolylines.Focused)
            {
                selectedShape = new PolylineShape(lineColor, lineWidth);
            }
            else if (bttnRectangle.Focused)
            {
                selectedShape = new RectangleShape(lineColor, lineWidth, fillColor);
            }
            else if (bttnEllipse.Focused)
            {
                selectedShape = new EllipseShape(lineColor, lineWidth, fillColor);
            }

            if (selectedShape != null)
            {
                p.X = e.X;
                p.Y = e.Y;
                Graphics paint;
                paint = panel1.CreateGraphics();
                shapes.Add(selectedShape);
                selectedShape.Draw(p, paint);
                selectedShape = null;
            }
        }


        private void bttnBack_Click(object sender, EventArgs e)
        {
            Graphics paint;
            paint = panel1.CreateGraphics();
            paint.Clear(Color.White);

            if (shapes.Count > 0 )
            {
                int ind = shapes.Count - 1;
                shapes.RemoveAt(ind);

                int i = 0;
                if (shapes != null)
                {
                    while (i <= shapes.Count - 1)
                    {
                        var shapee = shapes.ElementAt(i);
                        shapee.Draw(paint);

                        i++;
                    }

                }
                
            }
        }

        private void bttnForward_Click(object sender, EventArgs e)
        {

           
        }

        private void cmbBoxLineColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = cmbBoxLineColor.SelectedItem.ToString();

            switch (selectedText)
            {
                case "Красный":
                    lineColor = Color.Red;
                    break;
                case "Зеленый":
                    lineColor = Color.Green;
                    break;
                case "Синий":
                    lineColor = Color.Blue;
                    break;
                case "Желтый":
                    lineColor = Color.Yellow;
                    break;
                case "Фиолетовый":
                    lineColor = Color.Purple;
                    break;
            }
        }

        private void cmbBoxFillColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = cmbBoxFillColor.SelectedItem.ToString();
            switch (selectedText)
            {
                case "Красный":
                    fillColor = Color.Red;
                    break;
                case "Зеленый":
                    fillColor = Color.Green;
                    break;
                case "Синий":
                    fillColor = Color.Blue;
                    break;
                case "Желтый":
                    fillColor = Color.Yellow;
                    break;
                case "Фиолетовый":
                    fillColor = Color.Purple;
                    break;
                case "Белый":
                    fillColor = Color.White;
                    break;
            }
        }

        private void numUDWidth_ValueChanged(object sender, EventArgs e)
        {
            lineWidth = (float)numUDWidth.Value;
        }
    }
}
