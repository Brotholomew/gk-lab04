using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk_drawing_template_temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Designer.Init(new DesignerParams(this.MainPictureBox));

            Vertex v1 = new Vertex(new Point2D(200, 200));
            Vertex v2 = new Vertex(new Point2D(400, 200));
            Vertex v3 = new Vertex(new Point2D(200, 400));
            Vertex v4 = new Vertex(new Point2D(400, 400));

            Line l1 = new Line(v1, v2);
            Line l2 = new Line(v2, v3);
            Line l3 = new Line(v3, v4);
            Line l4 = new Line(v4, v1);

            Polygon p = new Polygon(new List<Drawable> { l1, l2, l3, l4 });
            p.Print(Designer.PrintingMode.Main);
            p.Fill(Designer.PrintingMode.Main, Color.Red);
        }

        private void MainCanvasPaint(object sender, PaintEventArgs e)
        {
            Designer.Instance.Repaint(e.Graphics);
        }
    }
}
