using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDrawing.Algorithms
{
    public class LineBresenham
    {
        private readonly System.Drawing.Graphics _graphics;
        private readonly System.Drawing.Pen _pen;

        public LineBresenham(System.Drawing.Graphics graphics, System.Drawing.Pen pen)
        {
            _graphics = graphics;
            _pen = pen;
        }

        public void Draw(int x0, int y0, int x1, int y1)
        {
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1, sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;
            while (true)
            {
                _graphics.DrawRectangle(_pen, x0, y0, 1, 1);
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }
    }
}