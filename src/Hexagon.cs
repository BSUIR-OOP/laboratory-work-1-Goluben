using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    class Hexagon: GeometricFigure
    {
        int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6;

        public Hexagon(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5, int x6, int y6)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
            this.x5 = x5;
            this.y5 = y5;
            this.x6 = x6;
            this.y6 = y6;
        }

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(x1, y1);
            Point b = new Point(x2, y2);
            Point c = new Point(x3, y3);
            Point d = new Point(x4, y4);
            Point e = new Point(x5, y5);
            Point f = new Point(x6, y6);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, d);
            graphic.DrawLine(pen, d, e);
            graphic.DrawLine(pen, e, f);
            graphic.DrawLine(pen, f, a);
        }
    }
}
