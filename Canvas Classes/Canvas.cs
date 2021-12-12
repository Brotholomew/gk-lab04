using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gk_drawing_template_temp
{
    public class Canvas
    {
        private HashSet<Drawable> MainDrawables;
        private HashSet<Drawable> PreviewDrawables;

        public DirectBitmap Main { get; private set; }
        public DirectBitmap Preview { get; private set; }

        private CanvasParams Params;

        public Canvas(CanvasParams p)
        {
            this.Params = p;

            this.MainDrawables = new HashSet<Drawable>();
            this.PreviewDrawables = new HashSet<Drawable>();

            this.Init();
        }

        private void Init()
        {
            this.Main = new DirectBitmap(this.Params.MainPictureBox.Width, this.Params.MainPictureBox.Height);
            this.Preview = new DirectBitmap(this.Params.MainPictureBox.Width, this.Params.MainPictureBox.Height);
        }

        public void Refresh() => this.Params.MainPictureBox.Refresh();
        public void Erase()
        {
            this.Main.Dispose();
            this.Preview.Dispose();

            this.Init();
        }
        public void Reprint()
        {
            this.Erase();

            foreach (var d in this.MainDrawables)
                d.Print(Designer.PrintingMode.Main);

            foreach (var d in this.PreviewDrawables)
                d.Print(Designer.PrintingMode.Preview);
        }

        public void Repaint(Graphics gx)
        {
            gx.DrawImage(this.Main.Bitmap, 0, 0);
            gx.DrawImage(this.Preview.Bitmap, 0, 0);
        }

        public DirectBitmap Bitmap(Designer.PrintingMode pm)
        {
            switch(pm)
            {
                case Designer.PrintingMode.Main:
                    return this.Main;
                case Designer.PrintingMode.Preview:
                    return this.Preview;
            }

            return null;
        }

        #region Switch Canvas

        public void AddToPreview(Drawable d) => this.PreviewDrawables.Add(d);

        public void AddToMain(Drawable d) => this.MainDrawables.Add(d);

        public void SwitchToPreview(Drawable d) => this.SwitchCanvas(this.MainDrawables, this.PreviewDrawables, d);

        public void SwitchToMain(Drawable d) => this.SwitchCanvas(this.PreviewDrawables, this.MainDrawables, d);

        private void SwitchCanvas(HashSet<Drawable> from, HashSet<Drawable> to, Drawable d)
        {
            if (from.Contains(d))
                from.Remove(d);

            to.Add(d);
        }

        #endregion
    }
}
