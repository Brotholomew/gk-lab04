using System;
using System.Collections.Generic;
using System.Text;

namespace gk_drawing_template_temp
{
    public class Point2D : IPoint
    {        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point2D(double X, double Y) => this.Init(X, Y);

        public Point2D(int X, int Y) => this.Init(X, Y);

        private void Init(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
            this.Z = 0;
        }

        public System.Drawing.Point SPoint() => new System.Drawing.Point((int)this.X, (int)this.Y);
    }
}
