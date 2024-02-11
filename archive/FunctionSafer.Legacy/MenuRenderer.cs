using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Safer_v2 {
    class MenuRenderer : ToolStripProfessionalRenderer {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs myMenu) {
            if (!myMenu.Item.Selected)
                base.OnRenderMenuItemBackground(myMenu);
            else {
                Rectangle menuRectangle = new Rectangle(Point.Empty, myMenu.Item.Size);
                myMenu.Graphics.FillRectangle(Brushes.DarkGray, menuRectangle);
                myMenu.Graphics.DrawRectangle(Pens.White, 1, 0, menuRectangle.Width - 2, menuRectangle.Height - 1);
            }
        }
    }
}