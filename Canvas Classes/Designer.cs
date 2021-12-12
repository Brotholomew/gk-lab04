using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gk_drawing_template_temp
{
    public class Designer
    {
        #region Singleton Fields and Methods

        public static Designer Instance { get => Designer._Instance; }
        
        public static void Init(DesignerParams p)
        {
            Designer._Instance = new Designer(p);
        }

        private static Designer _Instance = null;

        private Designer(DesignerParams p)
        {
            this.Params = p;

            this.Canvas = new Canvas(new CanvasParams(this.Params.MainPictureBox));
            this.Printer = new Printer(new PrinterParams());
            this.Filler = new Filler(new FillerParams());
        }

        #endregion

        private DesignerParams Params;

        private Canvas Canvas;
        private Printer Printer;
        private Filler Filler;

        public void Refresh() => this.Canvas.Refresh();
        public void Erase() => this.Canvas.Erase();
        public void Reprint() => this.Canvas.Reprint();
      
        public enum PrintingMode { Main, Preview };

        public void PrintLine(IPoint a, IPoint b, PrintingMode pm) => this.Printer.PrintLine(a, b, this.Canvas.Bitmap(pm).Bitmap);
        public void PrintVertex(IPoint a, PrintingMode pm) => this.Printer.PrintVertex(a, this.Canvas.Bitmap(pm).Bitmap);

        public void PutPixel(IPoint a, PrintingMode pm, Color c) => this.Printer.PutPixel(a, this.Canvas.Bitmap(pm), c);

        public void FillDrawable(Drawable d, Color c, PrintingMode pm) => this.Filler.ScanLine(d, c, pm);

        public void Repaint(Graphics gx) => this.Canvas.Repaint(gx);
    }
}
