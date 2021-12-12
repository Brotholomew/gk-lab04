using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace gk_drawing_template_temp
{
    public struct DesignerParams
    {
        public PictureBox MainPictureBox;

        public DesignerParams(
            PictureBox mainPictureBox
            )
        {
            this.MainPictureBox = mainPictureBox;
        }
    }
}
