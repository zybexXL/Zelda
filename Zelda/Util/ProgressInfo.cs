using System;

namespace Zelda
{
    // status tracker for several ProgressBar tasks
    public class ProgressInfo
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public int currentItem { get; set; }
        public int totalItems { get; set; }
        public DateTime startTime { get; set; }
        public bool cancelled { get; set; }
        public bool paused { get; set; }
        public object[] args { get; set; }
        public bool result { get; set; }
        public bool canCancel { get; set; } = true;


        public Action RefreshHandler;

        private DateTime lastUpdate;


        public ProgressInfo(string Title, int items = 0)
        {
            startTime = DateTime.Now;
            title = Title;
            totalItems = items;
        }

        public void Update(bool immediate = true)
        {
            lock (this)
            {
                if (!immediate && lastUpdate.AddMilliseconds(100) > DateTime.Now)
                    return;
                if (!immediate) lastUpdate = DateTime.Now;
            }
            RefreshHandler?.Invoke();
        }
    }
}
