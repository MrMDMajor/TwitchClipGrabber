using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Twitch_Clip_Grabber
{
    static class UserSettings
    {
        public static string FormatFilename(Clip clip)
        {
            GetClipDict(clip, Properties.Settings.Default.TimeSpanFormat, Properties.Settings.Default.DateTimeFormat);
            Regex regex = new Regex(@"\{.*?\}");
            MatchCollection matches = regex.Matches(Properties.Settings.Default.FilenameFormat);
            string output = Properties.Settings.Default.FilenameFormat;
            foreach (Match match in matches)
            {
                if (clip.clipDict.ContainsKey(match.Value))
                {
                    output = output.Replace(match.Value, clip.clipDict[match.Value]);
                }
            }
            Console.WriteLine(output);
            return output + ".mp4";
        }
        private static void GetClipDict(Clip clip, string timeSpanFormat, string dateTimeFormat)
        {
            clip.clipDict = new Dictionary<string, string>()
            {
                {"{broadcaster_name}", clip.broadcaster_name },
                {"{created_at}", clip.created_at.ToString(dateTimeFormat) },
                {"{creator_name}", clip.creator_name },
                {"{duration}", clip.duration.ToString() + "s" },
                {"{title}", clip.title },
                {"{url}", clip.url },
                {"{vod_offset}", TimeSpan.FromSeconds(clip.vod_offset).ToString(timeSpanFormat) },
                {"{today}", DateTime.Today.ToString(dateTimeFormat) },
                {"{vod_date}", clip.vodDate.ToString(dateTimeFormat) }
            };
        }
    }
}
