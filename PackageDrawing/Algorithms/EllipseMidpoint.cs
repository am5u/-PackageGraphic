using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDrawing.Algorithms
{
    public class EllipseMidpoint
    {
        private readonly System.Drawing.Graphics _graphics;
        private readonly System.Drawing.Pen _pen;

        public EllipseMidpoint(System.Drawing.Graphics graphics, System.Drawing.Pen pen)
        {
            _graphics = graphics;
            _pen = pen;
        }

        public void Draw(int x0, int y0, int a, int b)
        {
            int x = 0, y = b;
            long aSq = a * a, bSq = b * b;
            long d = bSq - aSq * b + aSq / 4;
            while (aSq * (y - 0.5) > bSq * (x + 1))
            {
                _graphics.DrawRectangle(_pen, x0 + x, y0 + y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - x, y0 + y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 + x, y0 - y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - x, y0 - y, 1, 1);
                if (d < 0) d += bSq * (2 * x + 3);
                else { d += bSq * (2 * x + 3) + aSq * (-2 * y + 2); y--; }
                x++;
            }
            d = (long)(bSq * (x + 0.5) * (x + 0.5) + aSq * (y - 1) * (y - 1) - aSq * bSq);
            while (y >= 0)
            {
                _graphics.DrawRectangle(_pen, x0 + x, y0 + y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - x, y0 + y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 + x, y0 - y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - x, y0 - y, 1, 1);
                if (d > 0) d += aSq * (-2 * y + 3);
                else { d += bSq * (2 * x + 2) + aSq * (-2 * y + 3); x++; }
                y--;
            }
        }
    }
}