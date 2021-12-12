using System;
using System.Collections.Generic;
using System.Text;

namespace gk_drawing_template_temp
{
    internal class Point3D : IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double X, double Y, double Z) => this.Init(X, Y, Z);

        public Point3D(int X, int Y, int Z) => this.Init(X, Y, Z);

        private void Init(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public System.Drawing.Point SPoint() => new System.Drawing.Point((int)this.X, (int)this.Y);
    }
}
