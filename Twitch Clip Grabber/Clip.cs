using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Clip_Grabber
{
    class Clip
    {
        public int broadcaster_id { get; set; }
        public string broadcaster_name { get; set; }
        public DateTimeOffset created_at { get; set; }
        public int creator_id { get; set; }
        public string creator_name { get; set; }
        public int duration { get; set; }
        public string embed_url { get; set; }
        public int game_id { get; set; }
        public string id { get; set; }
        public string language { get; set; }
        public string thumbnail_url { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public int video_id { get; set; }
        public int view_count { get; set; }
    }
}
