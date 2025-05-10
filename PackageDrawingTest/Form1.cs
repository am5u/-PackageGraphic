using System.Drawing;
using System.Windows.Forms;
using PackageDrawing.Core;

namespace PackageDrawingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true; 
            Text = "Package Drawing Test"; 
            Width = 600; 
            Height = 400;
            ResizeRedraw = true; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var context = new DrawingContext(e.Graphics, new Pen(Color.Black, 1));

           
            context.LineDDA.Draw(50, 50, 150, 150);    
            context.LineBresenham.Draw(50, 200, 150, 300); 
            context.Circle.Draw(200, 200, 50);          
            context.Ellipse.Draw(300, 200, 60, 40);    
        }
    }
}