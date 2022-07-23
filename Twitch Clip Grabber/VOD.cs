using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Clip_Grabber
{
    public class VODCollection
    {
        public List<VOD> data { get; set; }
        public Pagination pagination { get; set; }

        public VODCollection()
        {
            data = new List<VOD>();
            pagination = new Pagination();
        }
    }

    public class Pagination
    {
        private string _cursor = "";
        public string cursor { 
            get { return _cursor; }
            set { if (value == null)
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
