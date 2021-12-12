using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gk_drawing_template_temp
{
    public class Line : Drawable
    {
        public IPoint A { get => this.Vertices[0].Center; }
        public IPoint B { get => this.Vertices[1].Center; }

        public Line(Vertex a, Vertex b)
        {
            a.Drawables.Add(this);
            b.Drawables.Add(this);

            this.Drawables = new List<Drawable>();
            this.Vertices = new List<Vertex>();

            this.Vertices.Add(a);
            this.Vertices.Add(b);
        }

        public override void Fill(Designer.PrintingMode pm, Color c)
        {
            // line shall not be drawn
        }

        public override void Print(Designer.PrintingMode pm)
        {
            foreach (var v in this.Vertices)
                v.Print(pm);

            Designer.Instance.PrintLine(this.A, this.B, pm);
        }
    }
}
