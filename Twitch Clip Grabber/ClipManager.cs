using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    class ClipManager
    {
        public async Task<ClipCollection> UpdateClipCollection(string id, string start)
        {
            ClipCollection outputCol = new ClipCollection();
            do
            {
                ClipCollection tempCol = await GetClipCollection(id, start, outputCol.pagination.cursor);
                outputCol.data.AddRange(tempCol.data);
                outputCol.pagination.cursor = tempCol.pagination.cursor;
            } while (outputCol.pagination.cursor != "");
            outputCol.data.Sort(outputCol);
            return outputCol;
        }

        private async Task<ClipCollection> GetClipCollection(string id, string start = "", string cursor = "")
        {
            string now = "";
            if (start != "")
            {
                now = DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"); 
            }
            string url = $"clips?broadcaster_id={id}&after={cursor}&started_at={start}&ended_at={now}";
            var response = await Http.GetResponse(url, true);
            string responseStr = await response.Content.ReadAsStringAsync();
            ClipCollection clipCol = JsonSerializer.Deserialize<ClipCollection>(responseStr);
            return clipCol;
        }
    }
}
