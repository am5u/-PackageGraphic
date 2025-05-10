using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDrawing.Algorithms
{
    public class LineDDA
    {
        private readonly System.Drawing.Graphics _graphics;
        private readonly System.Drawing.Pen _pen;

        public LineDDA(System.Drawing.Graphics graphics, System.Drawing.Pen pen)
        {
            _graphics = graphics;
            _pen = pen;
        }

        public void Draw(int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0, dy = y1 - y0;
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            float xInc = dx / (float)steps, yInc = dy / (float)steps;
            float x = x0, y = y0;
            for (int i = 0; i <= steps; i++)
            {
                _graphics.DrawRectangle(_pen, (int)x, (int)y, 1, 1);
                x += xInc;
                y += yInc;
            }
        }
    }
}