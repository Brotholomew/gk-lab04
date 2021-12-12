using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gk_drawing_template_temp
{
    public class Vertex : Drawable
    {
        public IPoint Center { get; set; }

        public Vertex(IPoint center)
        {
            Center = center;

            this.Vertices = new List<Vertex>();
            this.Drawables = new List<Drawable>();

            this.Vertices.Add(this);
        }

        public override void Fill(Designer.PrintingMode pm, Color c)
        {
            // vertices shall not be filled
        }

        public override void Print(Designer.PrintingMode pm) => Designer.Instance.PrintVertex(this.Center, pm);
    }
}
