using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Twitch_Clip_Grabber
{
    public partial class Form1 : Form
    {
        string id;
        string clipStartDate;

        VODCollection vodCol;
        ClipCollection clipCol;

        VODManager vodManager = new();
        ClipManager clipManager = new();
        List<int> selectedIndices = new List<int>();

        ProgressBar pb = new();
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
            id = await GetUserID(username.Text);
            vodCol = new VODCollection();
            vodCol = await vodManager.UpdateVODCollection(id);
            GetListViewVOD(vodCol, listView1);
        }

        private async Task<string> GetUserID(string username)
        {
            if (username != "")
            {
                var response = await Http.GetResponse($"users?login={username}", true);
                if (response.IsSuccessStatusCode)
                {
                    string responseStr = await response.Content.ReadAsStringAsync();
                    JsonDocument document = JsonDocument.Parse(responseStr);
                    string id = document.RootElement.GetProperty("data")[0].GetProperty("id").ToString();
                    return id;
                }
                else return null;
            }
            else return null;
        }

        private void GetListViewVOD(VODCollection collection, ListView view)
        {
            ImageList largeImgList = new();
            ImageList smallImgList = new();
            largeImgList.ImageSize = new Size(256, 144);
            smallImgList.ImageSize = new Size(64, 36);
            largeImgList.ColorDepth = ColorDepth.Depth32Bit;
            smallImgList.ColorDepth = ColorDepth.Depth32Bit;
            List<ListViewItem> items = new();

            for (int i = 0; i < collection.data.Count; i++)
            {
                Image img = collection.data[i].thumbnail;
                largeImgList.Images.Add(img);
                smallImgList.Images.Add(img);
                string createdAt = collection.data[i].created_at.ToString("yyyy/MM/dd");
                string title = collection.data[i].title;
                items.Add(new ListViewItem(new string[] { title, createdAt }, i));
            }
            view.Items.Clear();
            view.LargeImageList = largeImgList;
            view.SmallImageList = smallImgList;
            view.Items.AddRange(items.ToArray());
        }

        private void GetListViewClip(ClipCollection collection, ListView view)
        {
            ImageList largeImgList = new();
            ImageList smallImgList = new();
            largeImgList.ImageSize = new Size(256, 144);
            smallImgList.ImageSize = new Size(64, 36);
            largeImgList.ColorDepth = ColorDepth.Depth32Bit;
            smallImgList.ColorDepth = ColorDepth.Depth32Bit;
            List<ListViewItem> items = new();

            for (int i = 0; i < collection.data.Count; i++)
            {
                Image img = collection.data[i].thumbnail;
                largeImgList.Images.Add(img);
                smallImgList.Images.Add(img);
                string creatorName = collection.data[i].creator_name;
                string title = collection.data[i].title;
                string createdAt = collection.data[i].created_at.ToString("yyyy/MM/dd");
                string offset = TimeSpan.FromSeconds(collection.data[i].vod_offset).ToString(@"hh\hmm\mss\s");
                items.Add(new ListViewItem(new string[] { title, creatorName, createdAt, offset }, i));
            }

            view.Items.Clear();
            view.SmallImageList = smallImgList;
            view.LargeImageList = largeImgList;
            view.Items.AddRange(items.ToArray());
        }
        private void viewDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (viewDropDown.SelectedItem)
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

        private async void getClipsButton_Click(object sender, EventArgs e)
        {
            pb.Text = "Getting clips...";
            pb.Show();
            clipCol = new ClipCollection();
            DateTime start = new DateTime();
            VOD vod = vodCol.data[listView1.SelectedIndices[0]];
            start = vod.created_at;
            clipStartDate = start.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");
            int progress = 0;

            ClipCollection newClipCol = await clipManager.UpdateClipCollection(id, clipStartDate);
            foreach (Clip clip in newClipCol.data)
            {
                if (clip.video_id == vod.id)
                {
                    clipCol.data.Add(clip);
                }
                pb.loadingProgressBar.Value = ++progress * 25 / newClipCol.data.Count;
            }
            progress = 0;
            foreach (Clip clip in clipCol.data)
            {
                clip.thumbnail = await Program.LoadImage(clip.thumbnail_url, new Size(128, 72));
                pb.loadingProgressBar.Value = 25 + (++progress * 75 / clipCol.data.Count);
            }
            await Task.Delay(500);
            pb.loadingProgressBar.Value = 0;
            pb.Hide();
            GetListViewClip(clipCol, listView2);
        }

        private void listView2_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadTarget.ShowDialog();
            foreach (ListViewItem item in listView2.CheckedItems)
            {
                string newUrl = clipCol.data[item.Index].thumbnail_url.Replace("-preview-480x272.jpg", ".mp4");
                Console.WriteLine(newUrl);
                Program.DownloadFile(newUrl, Path.Combine(downloadTarget.SelectedPath, UserSettings.FormatFilename(clipCol.data[item.Index])));
            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                item.Checked = true;
            }
        }
        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                item.Checked = false;
            }
        }
    }
}
