using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;

namespace TwitchClipGrabber
{
    static class UserSettings
    {

        public static string FormatFilename(Clip clip, string filenameFormat)
        {
            GetClipDict(clip);
            Regex regex = new Regex(@"\{.*?\}");
            string output = filenameFormat;
            MatchCollection matches = regex.Matches(output);
            foreach (Match match in matches)
            {
                string key = match.Value;
                string format = "";
                if (match.Value.Contains(":"))
                {
                    regex = new Regex(@"(\{.*?):(.*?)(\})");
                    Match newMatch = regex.Match(match.Value);
                    key = newMatch.Groups[1].Value + newMatch.Groups[3].Value;
                    format = newMatch.Groups[2].Value;
                    if (clip.clipDict.ContainsKey(key))
                    {
                        if (key == "{vod_offset}")
                        {
                            var timeSpan = (TimeSpan)clip.clipDict[key];
                            try { output = output.Replace(match.Value, timeSpan.ToString(format)); }
                            catch { output = output.Replace(match.Value, timeSpan.ToString()); }
                        }
                        else
                        {
                            var dateTime = (DateTime)clip.clipDict[key];
                            output = output.Replace(match.Value, dateTime.ToString(format));
                        }
                    }
                }
                else if (clip.clipDict.ContainsKey(key))
                {
                    output = output.Replace(match.Value, clip.clipDict[key].ToString());
                }
            }
            var invalids = System.IO.Path.GetInvalidFileNameChars();
            var newOutput = String.Join("_", output.Split(invalids, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
            return newOutput + ".mp4";
        }
        private static void GetClipDict(Clip clip)
        {
            clip.clipDict = new Dictionary<string, object>()
            {
                {"{broadcaster_name}", clip.broadcaster_name },
                {"{created_at}", clip.created_at },
                {"{creator_name}", clip.creator_name },
                {"{id}", clip.id },
                {"{duration}", clip.duration.ToString() + "s" },
                {"{title}", clip.title },
                {"{url}", clip.url },
                {"{vod_offset}", clip.vod_offset != null ? TimeSpan.FromSeconds((double)clip.vod_offset) : 0 },
                {"{today}", DateTime.Today },
                {"{vod_date}", clip.vod_date }
            };
        }
    }
}
