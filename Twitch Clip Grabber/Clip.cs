using System;
using System.Collections.Generic;
using System.Drawing;

namespace TwitchClipGrabber
{

    public class ClipCollection : IComparer<Clip>
    {
        public List<Clip> data { get; set; }
        public Pagination pagination { get; set; }

        public ClipCollection()
        {
            data = new List<Clip>();
            pagination = new Pagination();
        }

        public int Compare(Clip x, Clip y)
        {
            int xInt, yInt;
            xInt = x.vod_offset == null ? 0 : (int)x.vod_offset;
            yInt = y.vod_offset == null ? 0 : (int)y.vod_offset;

            return xInt.CompareTo(yInt);
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
