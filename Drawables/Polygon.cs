using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gk_drawing_template_temp
{
    public class Polygon : Drawable
    {
        public override List<Vertex> Vertices
        {
            get
            {
                List<Vertex> verts = new List<Vertex>();
                
                foreach (var d in this.Drawables)
                    verts.AddRange(d.Vertices);

                return verts;
            }
        }

        public Polygon(List<Drawable> Lines)
        {
            foreach (var line in Lines)
                line.Drawables.Add(this);

            this.Drawables = Lines;
        }

        public override void Fill(Designer.PrintingMode pm, Color c) => Designer.Instance.FillDrawable(this, c, pm);

        public override void Print(Designer.PrintingMode pm)
        {
            foreach (var d in this.Drawables)
                d.Print(pm);
        }
    }
}
