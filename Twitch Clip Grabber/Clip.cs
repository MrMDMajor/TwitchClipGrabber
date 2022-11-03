using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TwitchClipGrabber
{

    public class ClipCollection : IComparer<Clip>
    {
        public List<Clip> data { get; set; }
        public Pagination pagination { get; set; }
        public SortOrder ClipSort { get; set; }
        public string SortField { get; set; }

        public ClipCollection()
        {
            data = new List<Clip>();
            pagination = new Pagination();
            SortField = "vod_offset";
        }

        public int Compare(Clip x, Clip y)
        {
            var xVal = x.GetType().GetProperty(SortField).GetValue(x) as IComparable;
            var yVal = y.GetType().GetProperty(SortField).GetValue(y) as IComparable;
            if (xVal != null && yVal != null)
            {
                if (ClipSort == SortOrder.Ascending)
                {
                    return xVal.CompareTo(yVal);
                }
                else if (ClipSort == SortOrder.Descending)
                {
                    return yVal.CompareTo(xVal);
                }
                else return 0;
            }
            else return 0;
        }
    }

    public class Clip
    {
        public string broadcaster_id { get; set; }
        public string broadcaster_name { get; set; }
        public DateTime created_at { get; set; }
        public string creator_id { get; set; }
        public string creator_name { get; set; }
        public float duration { get; set; }
        public string embed_url { get; set; }
        public string game_id { get; set; }
        public string id { get; set; }
        public string language { get; set; }
        public string thumbnail_url { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string video_id { get; set; }
        public int view_count { get; set; }
        public Image thumbnail { get; set; }
        public int? vod_offset { get; set; }
        public DateTime vod_date { get; set; }
        public Dictionary<string, object> clipDict { get; set; }
        public string download_url { get; set; }
    }
}
