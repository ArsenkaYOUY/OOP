using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private int buttonCount = 0;
        private Shape selectedShape;
        private Point p = new Point();
        private float lineWidth = 2;
        private Color lineColor = Color.Red;
        private Color fillColor = Color.Red;
        private int currShapesIndex = -1;

        private List<Shape> shapes;

        private void DrawShapes(int index) 
        {
            Graphics paint;
            using (paint = panel1.CreateGraphics())
            {
                paint.Clear(Color.White);
                int i = 0;
                if (shapes != null)
                {
                    while (i < index + 1)
                    {
                        var shapee = shapes.ElementAt(i);
                        shapee.Draw(paint);

                        i++;
                    }
                }
            }              
        }

        public MainForm()
        {
            InitializeComponent();
            shapes = new List<Shape> { };

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
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
            else
            {
                selectedShape = shapeFromPlugin();
            }

            if (selectedShape != null)
            {
                p.X = e.X;
                p.Y = e.Y;
                Graphics paint;
                using (paint = panel1.CreateGraphics())
                {
                    if (shapes.Count != 0)
                        shapes.RemoveRange(currShapesIndex + 1, shapes.Count - currShapesIndex - 1);

                    shapes.Add(selectedShape);
                    currShapesIndex++;
                    selectedShape.Draw(p, paint);
                }

                ;
               
                selectedShape = null;
            }
        }


        private void bttnBack_Click(object sender, EventArgs e)
        {
            if (currShapesIndex != -1)
            {
                currShapesIndex--;
                DrawShapes(currShapesIndex);
            }
        }

        private void bttnForward_Click(object sender, EventArgs e)
        {
            if (shapes.Count != currShapesIndex + 1)
            {
                currShapesIndex++;
                DrawShapes(currShapesIndex);
            }
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

        private void bttnLoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (File.Exists(filePath))
                    {

                        string json = File.ReadAllText(filePath);

                        var options = new JsonSerializerOptions
                        {
                            Converters = { new JsonStringEnumConverter() }
                        };
                        shapes =  JsonSerializer.Deserialize<List<Shape>>(json, options);
                        currShapesIndex = shapes.Count - 1;
                        DrawShapes(currShapesIndex);
                        MessageBox.Show("Файл успешно загружен.");
                    }
                    else
                    {
                        MessageBox.Show("Файл не найден.");
                    }
                }
            }
        }


        private void bttnSaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Сохраните файл";
                saveFileDialog.FileName = "shapes.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (shapes.Count != 0)
                        shapes.RemoveRange(currShapesIndex + 1, shapes.Count - currShapesIndex - 1);

                    var options = new JsonSerializerOptions
                    {
                         WriteIndented = true,
                         Converters = { new JsonStringEnumConverter() }
                    };
                    string json = JsonSerializer.Serialize(shapes, options);

                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Файл успешно сохранен.");
                }
            }
        }

        private Shape shapeFromPlugin()
        {
            // ДОРАБОТАТЬ! НЕ ПРОВЕРЯЕТСЯ ФОКУСИРОВКА НА КНОПКЕ
            Shape selectedShape = null;
            foreach (Control ctrl in groupBox3.Controls)
            {
                // если ctrl = button, то сохраняется в переменную existingButton.
                if (ctrl is Button existingButton)
                {
                    switch (existingButton.Text)
                    {
                        case "Пятиугольник":
                            selectedShape = new PolylineShape(lineColor, lineWidth);
                            // Как-то загрузить из файла классы, создать объект нужного класса или что-то такое
                            // Сделать также с сериализацией
                            //selectedShape = new PolylineShape(lineColor, lineWidth);
                            break;
                        case "Звезда":
                            break;
                        case "Еще что-то":
                            break;
                    }
                }
                if (selectedShape != null)
                    break;
            }

            return selectedShape;
        }

        private void AddButton (string bttnText)
        {
            foreach (Control ctrl in groupBox3.Controls)
            {
                // если ctrl = button, то сохраняется в переменную existingButton.
                if (ctrl is Button existingButton && existingButton.Text == bttnText)
                {
                    MessageBox.Show("Добавляемая фигура уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Прерываем выполнение метода, если кнопка уже есть
                }
            }

            Button button = new Button();
            button.Text = bttnText; 
            button.BackColor = Color.White; // Белый фон
            button.Size = new Size(126, 49);

            int padding = 10;
            button.Location = new Point(padding, buttonCount * button.Height + padding + 5);

            groupBox3.Controls.Add(button);

            // Увеличиваем счётчик кнопок
            buttonCount++;

            MessageBox.Show("Фигура " + bttnText + " успешно добавлена");

        }



        private void bttnAddPlugins_Click(object sender, EventArgs e)
        {
            List<string> shapesToAdd = new List<string> { "Треугольник", "Звезда", "Пятиугольник" }; 
            // Заменить на реальные фигуры

            PluginSelectionForm PluginForm = new PluginSelectionForm(shapesToAdd);

            if (PluginForm.ShowDialog() == DialogResult.OK)
            {
                string selectedShape = PluginForm.SelectedShape; 
                if (!string.IsNullOrEmpty(selectedShape))
                {
                    AddButton(selectedShape);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
