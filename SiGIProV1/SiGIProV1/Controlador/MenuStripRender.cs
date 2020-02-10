using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class MenuStripRender : ToolStripProfessionalRenderer
    {
        public MenuStripRender()
        {

        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // DO NOT CALL BASE EVENT (DO NOTHING FOR NO BORDER)
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {

            if (!e.Item.Selected)
            {
                e.Item.ForeColor = Color.FromArgb(220, 220, 220);
                base.OnRenderMenuItemBackground(e);
            }
            else
            {
                Pen oPen = new Pen(Color.FromArgb(17, 17, 32));
                SolidBrush oBrsh = new SolidBrush(Color.FromArgb(17, 17, 32));

                e.Item.ForeColor = Color.FromArgb(220, 220, 220);
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(oBrsh, rc);
                e.Graphics.DrawRectangle(oPen, 0, 0, rc.Width, rc.Height);

                oPen.Dispose();
                oBrsh.Dispose();
            }
        }
    }
}
