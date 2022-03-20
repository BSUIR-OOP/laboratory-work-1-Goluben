using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    class Ellipse: GeometricFigure
    {
        int x, y, width, height;

        public Ellipse(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            graphic.DrawEllipse(pen, x, y, width, height);
        }

    }
}
