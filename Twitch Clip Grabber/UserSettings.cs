using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Clip_Grabber
{
    static class UserSettings
    {
        public static string FormatFilename(Clip clip)
        {
            return TimeSpan.FromSeconds(clip.vod_offset).ToString(@"hh\hmm\mss\s") + ".mp4";
        }
    }
}
