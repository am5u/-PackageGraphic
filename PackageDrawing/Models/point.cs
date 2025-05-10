using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDrawing.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Translate(int tx, int ty)
        {
            X += tx;
            Y += ty;
        }

        public void Scale(float sx, float sy)
        {
            X = (int)(X * sx);
            Y = (int)(Y * sy);
        }

        public void Rotate(double angle)
        {
            double rad = angle * Math.PI / 180;
            int newX = (int)(X * Math.Cos(rad) - Y * Math.Sin(rad));
            int newY = (int)(X * Math.Sin(rad) + Y * Math.Cos(rad));
            X = newX;
            Y = newY;
        }

        public void ReflectX()
        {
            Y = -Y;
        }

        public void ShearX(int y, float shx)
        {
            X = (int)(X + shx * y);
        }
    }
}