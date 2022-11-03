using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TwitchClipGrabber
{
    public class VODCollection : IComparer<VOD>
    {
        public List<VOD> data { get; set; }
        public Pagination pagination { get; set; }
        public SortOrder VODSort { get; set; }
        public string SortField { get; set; }

        public VODCollection()
        {
            data = new List<VOD>();
            pagination = new Pagination();
        }

        public int Compare(VOD x, VOD y)
        {
            var xVal = x.GetType().GetProperty(SortField).GetValue(x) as IComparable;
            var yVal = y.GetType().GetProperty(SortField).GetValue(y) as IComparable;
            if (SortField == "duration")
            {
                xVal = TimeSpan.Parse(xVal.ToString().Replace('h', ':').Replace('m', ':').Replace("s", String.Empty));
                yVal = TimeSpan.Parse(yVal.ToString().Replace('h', ':').Replace('m', ':').Replace("s", String.Empty));
            }
            if (VODSort == SortOrder.Ascending)
            {
                return xVal.CompareTo(yVal);
            }
            else if (VODSort == SortOrder.Descending)
            {
                return yVal.CompareTo(xVal);
            }
            else return 0;
        }
    }

    public class Pagination
    {
        private string _cursor = "";
        public string cursor
        {
            get { return _cursor; }
            set
            {
                if (value == null)
                {
                    _cursor = "";
                }
                else
                {
                    _cursor = value;
                }
            }
        }
    }

    public class VOD
    {
        public DateTime created_at { get; set; }
        public string description { get; set; }
        public string duration { get; set; }
        public string id { get; set; }
        public string language { get; set; }
        public object muted_segments { get; set; }
        public DateTime published_at { get; set; }
        public string stream_id { get; set; }
        public string thumbnail_url { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string user_id { get; set; }
        public string user_login { get; set; }
        public string user_name { get; set; }
        public int view_count { get; set; }
        public string viewable { get; set; }
        public Image thumbnail { get; set; }
    }
}
