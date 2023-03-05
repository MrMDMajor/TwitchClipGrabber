using System.Windows.Forms;

namespace TwitchClipGrabber
{
    class CustomListView : ListView
    {
        private bool checkFromDoubleClick = false;
        private int _sortedColumnIndex = -1;
        public int SortedColumnIndex
        {
            get { return _sortedColumnIndex; }
            set { _sortedColumnIndex = value; }
        }

        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {
            if (this.checkFromDoubleClick)
            {
                ice.NewValue = ice.CurrentValue;
                this.checkFromDoubleClick = false;
            }
            else
            {
                base.OnItemCheck(ice);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (e.Clicks > 1))
            {
                this.checkFromDoubleClick = true;
            }
            base.OnMouseDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            this.checkFromDoubleClick = false;
            base.OnKeyDown(e);
        }
    }
}
