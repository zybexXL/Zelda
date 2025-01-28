using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms
{
    [DesignerCategory("code")]
    public class TransparentTrackBar : TrackBar
    {
        protected override void OnCreateControl()
        {
            VisualStyleRenderer oRenderer = new VisualStyleRenderer(
              VisualStyleElement.Tab.Pane.Normal);

            BackColor = oRenderer.GetColor(ColorProperty.FillColorHint);
            base.OnCreateControl();
        }
    }
}
