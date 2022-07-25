using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Clip_Grabber
{
    static class ExampleClip
    {
        public static Clip clip;
        static ExampleClip()
        {
            clip = new();
            clip.broadcaster_name = "StreamerMan1234";
            clip.created_at = new DateTime(2022, 2, 23);
            clip.creator_name = "Clippy";
            clip.duration = 30;
            clip.title = "BEST CLIP EVER (no clickbait)";
            clip.url = "www.example.com";
            clip.vod_offset = 1234;
            clip.vodDate = new DateTime(2009, 12, 14);
        }
    }
}
