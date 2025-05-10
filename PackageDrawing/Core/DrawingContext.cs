using System;
using System.Drawing;
using PackageDrawing.Algorithms;

namespace PackageDrawing.Core
{
    public class DrawingContext
    {
        private readonly Graphics _graphics;
        private readonly Pen _pen;

        public DrawingContext(Graphics graphics, Pen pen)
        {
            _graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));
            _pen = pen ?? throw new ArgumentNullException(nameof(pen));
        }

        public LineDDA LineDDA => new LineDDA(_graphics, _pen);
        public LineBresenham LineBresenham => new LineBresenham(_graphics, _pen);
        public CircleBresenham Circle => new CircleBresenham(_graphics, _pen);
        public EllipseMidpoint Ellipse => new EllipseMidpoint(_graphics, _pen);
        public Transformations Transformations => new Transformations();
    }
}