using System;
using System.Collections.Generic;
using System.Text;

namespace gk_drawing_template_temp
{
    public interface IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public System.Drawing.Point SPoint();
    }
}
