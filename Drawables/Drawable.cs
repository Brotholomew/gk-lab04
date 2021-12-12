using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gk_drawing_template_temp
{
    public abstract class Drawable
    {
        public List<Drawable> Drawables { get; set; }
        public virtual List<Vertex> Vertices { get; set; }

        public abstract void Print(Designer.PrintingMode pm);
        public abstract void Fill(Designer.PrintingMode pm, Color c);
    }
}
