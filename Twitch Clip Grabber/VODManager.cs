using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    class VODManager
    {
        public async Task<VODCollection> UpdateVODCollection(string id)
        {
            VODCollection outputCol = new VODCollection();
            int iterations = 0;
            Form1.pb.Text = "Loading VODs...";
            Form1.pb.Show(Form.ActiveForm);

            //Goes through all possible pages of VODs and combines them into a single list
            do
            {
                VODCollection tempCol = await GetVODCollection(id, cursor: outputCol.pagination.cursor);
                outputCol.data.AddRange(tempCol.data);
                outputCol.pagination.cursor = tempCol.pagination.cursor;
                iterations++;
            } while (outputCol.pagination.cursor != "");
            Form1.pb.Hide();
            Form1.pb.UpdateProgressBar();
            return outputCol;
        }

        private async Task<VODCollection> GetVODCollection(string id, string cursor = "")
        {
            string url = $"videos?user_id={id}&type=archive&after={cursor}&first=100";
            var response = await Http.GetResponse(url, true);
            string responseStr = await response.Content.ReadAsStringAsync();
            VODCollection vodCol = JsonSerializer.Deserialize<VODCollection>(responseStr);
            int progress = 0;
            foreach (VOD v in vodCol.data)
            {
                v.thumbnail = await Program.LoadImage(v.thumbnail_url, new Size(256, 144));
                Form1.pb.UpdateProgressBar(++progress * 100 / vodCol.data.Count);      
            }
            await Task.Delay(350);
            return vodCol;
        }
    }
}
