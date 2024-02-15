using System.ComponentModel;
using Zelda;

namespace System.Windows.Forms
{
    [DesignerCategory("code")]
    public class DraggableTabControl : TabControl
    {
        private TabPage predraggedTab;
        private int lastSwitchHash;
        private DateTime lastSwitchTime;

        public DraggableTabControl()
        {
            this.AllowDrop = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            predraggedTab = getPointedTab();

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            predraggedTab = null;

            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && predraggedTab != null)
                this.DoDragDrop(predraggedTab, DragDropEffects.Move);

            base.OnMouseMove(e);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            if (predraggedTab != null)
            {
                Type tabType = predraggedTab.GetType();
                TabPage draggedTab = drgevent.Data.GetData(tabType) as TabPage;
                TabPage pointedTab = getPointedTab();

                if (draggedTab == predraggedTab && pointedTab != null)
                {
                    drgevent.Effect = DragDropEffects.Move;

                    if (pointedTab != draggedTab)
                        swapTabPages(draggedTab, pointedTab);
                }
            }

            base.OnDragOver(drgevent);
        }

        private TabPage getPointedTab()
        {
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                var tabRect = GetTabRect(i);
                var mousePos = PointToClient(Cursor.Position);
                if (tabRect.Contains(mousePos))
                    return this.TabPages[i];
            }
            return null;
        }

        private void swapTabPages(TabPage src, TabPage dst)
        {
            int hash = src.GetHashCode() + dst.GetHashCode();
            if (hash == lastSwitchHash && lastSwitchTime.AddMilliseconds(500) > DateTime.Now)
                return;

            lastSwitchHash = hash;
            lastSwitchTime = DateTime.Now;

            int srci = this.TabPages.IndexOf(src);
            int dsti = this.TabPages.IndexOf(dst);

            this.TabPages[dsti] = src;
            this.TabPages[srci] = dst;

            if (this.SelectedIndex == srci)
                this.SelectedIndex = dsti;
            else if (this.SelectedIndex == dsti)
                this.SelectedIndex = srci;

            this.Refresh();
        }
    }
}

