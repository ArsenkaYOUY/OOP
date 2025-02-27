using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Shape
    {
        protected Pen pen;

        public Shape(Color color, float width)
        {
            pen = new Pen(color, width);
        }

        public abstract void Draw(Graphics e);

        public virtual void Dispose()
        {
            pen.Dispose();
        }
    }
}
