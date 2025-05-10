using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDrawing.Algorithms
{
    public class CircleBresenham
    {
        private readonly System.Drawing.Graphics _graphics;
        private readonly System.Drawing.Pen _pen;

        public CircleBresenham(System.Drawing.Graphics graphics, System.Drawing.Pen pen)
        {
            _graphics = graphics;
            _pen = pen;
        }

        public void Draw(int x0, int y0, int radius)
        {
            int x = 0, y = radius;
            int d = 3 - 2 * radius;
            while (x <= y)
            {
                _graphics.DrawRectangle(_pen, x0 + x, y0 + y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - x, y0 + y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 + x, y0 - y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - x, y0 - y, 1, 1);
                _graphics.DrawRectangle(_pen, x0 + y, y0 + x, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - y, y0 + x, 1, 1);
                _graphics.DrawRectangle(_pen, x0 + y, y0 - x, 1, 1);
                _graphics.DrawRectangle(_pen, x0 - y, y0 - x, 1, 1);
                if (d < 0) d += 4 * x + 6;
                else { d += 4 * (x - y) + 10; y--; }
                x++;
            }
        }
    }
}