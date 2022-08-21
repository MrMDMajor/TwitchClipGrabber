using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace TwitchClipGrabber
{
    class ClipManager
    {
        //
        private async Task<ClipCollection> GetClipCollection(string id, DateTime start, string cursor = "")
        {
            string now = "";
            string startString = "";
            if (start != default(DateTime))
            {
                startString = start.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
                now = DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
            }
            string url = $"clips?broadcaster_id={id}&after={cursor}&started_at={startString}&ended_at={now}";
            var response = await Http.GetResponse(url, true);
            string responseStr = await response.Content.ReadAsStringAsync();
            ClipCollection clipCol = JsonSerializer.Deserialize<ClipCollection>(responseStr);
            return clipCol;
        }

        //Grabs all clips created after specified start time
        public async Task<ClipCollection> UpdateClipCollection(string id, DateTime start)
        {
            ClipCollection outputCol = new ClipCollection();
            do
            {
                ClipCollection tempCol = await GetClipCollection(id, start, outputCol.pagination.cursor);
                foreach (Clip clip in tempCol.data)
                {
                    clip.vod_date = start;
                    clip.download_url = clip.thumbnail_url.Replace(@"-preview-480x272.jpg", ".mp4");
                }
                outputCol.data.AddRange(tempCol.data);
                outputCol.pagination.cursor = tempCol.pagination.cursor;
            } while (outputCol.pagination.cursor != "");
            outputCol.data.Sort(outputCol);
            return outputCol;
        }

    }
}
