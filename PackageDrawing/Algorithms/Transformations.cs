using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageDrawing.Models;


namespace PackageDrawing.Algorithms
{
    public class Transformations
    {
        public int[,] Translate(int[,] points, int dx, int dy)
        {
            int rows = points.GetLength(0);
            int cols = points.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = points[i, 0] + dx; // x-coordinate
                result[i, 1] = points[i, 1] + dy; // y-coordinate
            }
            return result;
        }

        public int[,] Scale(int[,] points, double sx, double sy)
        {
            int rows = points.GetLength(0);
            int cols = points.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = (int)(points[i, 0] * sx); // x-coordinate
                result[i, 1] = (int)(points[i, 1] * sy); // y-coordinate
            }
            return result;
        }

        public int[,] Rotate(int[,] points, double angleDegrees)
        {
            int rows = points.GetLength(0);
            int cols = points.GetLength(1);
            int[,] result = new int[rows, cols];
            double angleRad = angleDegrees * Math.PI / 180;
            int centerX = 100; // Assuming center of rotation is (100, 100)
            int centerY = 100;

            for (int i = 0; i < rows; i++)
            {
                int x = points[i, 0] - centerX;
                int y = points[i, 1] - centerY;
                result[i, 0] = (int)(x * Math.Cos(angleRad) - y * Math.Sin(angleRad)) + centerX;
                result[i, 1] = (int)(x * Math.Sin(angleRad) + y * Math.Cos(angleRad)) + centerY;
            }
            return result;
        }

        public int[,] Reflect(int[,] points, string axis)
        {
            int rows = points.GetLength(0);
            int cols = points.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = points[i, 0];
                result[i, 1] = points[i, 1];
                if (axis.ToLower() == "x") result[i, 1] = -points[i, 1] + 200; // Reflect over x-axis (adjust 200 for form height)
                else if (axis.ToLower() == "y") result[i, 0] = -points[i, 0] + 400; // Reflect over y-axis (adjust 400 for form width)
            }
            return result;
        }

        public int[,] Shear(int[,] points, double shx, double shy)
        {
            int rows = points.GetLength(0);
            int cols = points.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = points[i, 0] + (int)(shy * points[i, 1]);
                result[i, 1] = points[i, 1] + (int)(shx * points[i, 0]);
            }
            return result;
        }
    }
}