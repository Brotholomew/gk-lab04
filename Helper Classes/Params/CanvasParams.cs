using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace gk_drawing_template_temp
{
    public struct CanvasParams
    {
        public PictureBox MainPictureBox;

        public CanvasParams(PictureBox mainPictureBox)
        {
            this.MainPictureBox = mainPictureBox;
        }
    }
}
