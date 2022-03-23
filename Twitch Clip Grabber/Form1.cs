using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.IO;
using static System.Windows.Forms.ListView;

namespace Twitch_Clip_Grabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Program.Token == "" || Program.Token == null)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private async void submit_Click(object sender, EventArgs e)
        {
            string id = await GetUserID(username.Text);
            GetVODs(id);
        }

        private async Task<HttpResponseMessage> GetResponse(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Authorization", "Bearer" + Program.Token);
            var response = await Http.client.GetAsync(url);
            return response;
        }

        private async Task<string> GetUserID(string username)
        {
            if (username != "")
            {
                var response = await GetResponse($"users?login={username}");
                string responseStr = await response.Content.ReadAsStringAsync();
                JsonDocument document = JsonDocument.Parse(responseStr);
                string id = document.RootElement.GetProperty("data")[0].GetProperty("id").ToString();
                return id;
            }
            else return null;
        }

        private async void GetVODs(string id)
        {
            var response = await GetResponse($"videos?user_id={id}&type=archive");
            string responseStr = await response.Content.ReadAsStringAsync();
            ImageList largeImgList = new();
            ImageList smallImgList = new();
            largeImgList.ImageSize = new Size(256, 144);
            smallImgList.ImageSize = new Size(64, 36);
            largeImgList.ColorDepth = ColorDepth.Depth32Bit;
            smallImgList.ColorDepth = ColorDepth.Depth32Bit;
            List<ListViewItem> items = new();
            JsonDocument document = JsonDocument.Parse(responseStr);
            foreach (JsonElement element in document.RootElement.GetProperty("data").EnumerateArray())
            {
                string title = element.GetProperty("title").ToString();
                DateTime date = DateTime.Parse(element.GetProperty("created_at").ToString());
                string dateStr = date.ToString("yyyy/MM/dd");
                Image img = await LoadImage(element.GetProperty("thumbnail_url").ToString(), largeImgList.ImageSize);
                largeImgList.Images.Add(title, img);
                smallImgList.Images.Add(title, img);
                items.Add(new ListViewItem(new string[] { title, dateStr }, title));
            }
            listView1.LargeImageList = largeImgList;
            listView1.SmallImageList = smallImgList;
            listView1.Items.AddRange(items.ToArray());
        }

        private async Task<Image> LoadImage(string uri, Size size)
        {
            uri = uri.Replace("%{width}", size.Width.ToString()).Replace("%{height}", size.Height.ToString());
            var response = await GetResponse(uri);
            Stream responseStream = await response.Content.ReadAsStreamAsync();
            return Image.FromStream(responseStream);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Details":
                    listView1.View = View.Details;
                    break;
                case "Large Icon":
                    listView1.View = View.LargeIcon;
                    break;
                case "Small Icon":
                    listView1.View = View.SmallIcon;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    break;
            }
        }
    }
}
