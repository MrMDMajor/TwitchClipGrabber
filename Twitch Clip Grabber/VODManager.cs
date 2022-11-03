﻿using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchClipGrabber
{
    class VODManager
    {
        public async Task<VODCollection> UpdateVODCollection(string id, Form1 form)
        {
            VODCollection outputCol = new VODCollection();
            form.progressStatusStrip.Visible = true;
            form.busyInt++;

            //Goes through all possible pages of VODs and combines them into a single list
            do
            {
                VODCollection tempCol = await GetVODCollection(id, form, cursor: outputCol.pagination.cursor);
                outputCol.data.AddRange(tempCol.data);
                outputCol.pagination.cursor = tempCol.pagination.cursor;

            } while (outputCol.pagination.cursor != "");
            form.busyInt--;
            if (form.busyInt == 0)
            {
                form.progressStatusStrip.Visible = false;
                form.progressBar.Value = 0;
                form.progressLabel.Text = ""; 
            }
            return outputCol;
        }

        private async Task<VODCollection> GetVODCollection(string id, Form1 form, string cursor = "")
        {
            string url = $"videos?user_id={id}&type=archive&after={cursor}&first=100";
            var response = await Http.GetResponse(url, true);
            string responseStr = await response.Content.ReadAsStringAsync();
            VODCollection vodCol = JsonSerializer.Deserialize<VODCollection>(responseStr);
            int progress = 0;
            foreach (VOD v in vodCol.data)
            {
                v.thumbnail = await Program.LoadImage(v.thumbnail_url, new Size(256, 144));
                form.progressBar.Value = ++progress * 100 / vodCol.data.Count;
                form.progressLabel.Text = string.Format("Getting VODs...  {0}%", form.progressBar.Value);
            }
            await Task.Delay(350);
            return vodCol;
        }
    }
}
