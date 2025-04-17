using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    [Serializable]
    public class SerializableColor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public SerializableColor() { }

        public SerializableColor(Color color)
        {
            R = color.R;
            G = color.G;
            B = color.B;
        }

        public Color ToColor()
        {
            return Color.FromArgb(R, G, B);
        }
    }
}
