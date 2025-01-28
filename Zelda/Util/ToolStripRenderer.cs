using System.Drawing;
using System.Windows.Forms;

namespace Zelda
{
    public class ToolstripRenderer : ToolStripProfessionalRenderer
    {
        public Brush CheckedColor = Brushes.YellowGreen;

        public ToolstripRenderer() { }

        public ToolstripRenderer(Color color)
        {
            CheckedColor = new SolidBrush(color);
        }

        // renderer to apply a backcolor on Checked toolstrip buttons
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var btn = e.Item as ToolStripButton;
            if (btn != null && btn.CheckOnClick && btn.Checked)
            {
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(CheckedColor, bounds);
            }
            else base.OnRenderButtonBackground(e);
        }

        // apply backcolor to toolstrip SplitButton
        protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var btn = e.Item as ToolStripSplitButton;
            if (btn != null && btn.BackColor != e.ToolStrip.BackColor && btn.BackColor != Color.Empty)
            {
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                using (var brush = new SolidBrush(btn.BackColor))
                    e.Graphics.FillRectangle(brush, bounds);
            }
            base.OnRenderSplitButtonBackground(e);
        }
    }
}
