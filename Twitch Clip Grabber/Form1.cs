using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using LibVLCSharp.Shared;

namespace TwitchClipGrabber
{
    public partial class Form1 : Form
    {
        string id;

        VODCollection vodCol;
        ClipCollection clipCol;

        VODManager vodManager = new();
        ClipManager clipManager = new();
        Form2 form2;

        public static ProgressBar pb = new();

        bool resizing = false;
        TableLayoutColumnStyleCollection columnStyles;
        int colIndex = -1;

        public Form1()
        {
            InitializeComponent();
            Http.ValidateToken();
            this.Shown += CheckToken;

            ListViewExtender extender = new ListViewExtender(listView2);
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(listView2.Columns.Count - 1);
            buttonAction.Click += preview_Click;

            extender.AddColumn(buttonAction);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            columnStyles = mainLayout.ColumnStyles;
        }

        private void CheckToken(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Token == "" || Properties.Settings.Default.Token == null)
            {
                form2 = new();
                form2.Show();
            }
        }

        //Takes user input username, and gets User ID, necessary for subsequent API calls
        private async Task<string> GetUserID(string username)
        {
            if (username != "")
            {
                var response = await Http.GetResponse($"users?login={username}", true);
                if (response.IsSuccessStatusCode)
                {
                    string responseStr = await response.Content.ReadAsStringAsync();
                    JsonDocument document = JsonDocument.Parse(responseStr);
                    if (document.RootElement.GetProperty("data").GetArrayLength() == 0)
                    {
                        MessageBox.Show("Invalid username.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                    else return document.RootElement.GetProperty("data")[0].GetProperty("id").ToString();
                }
                else return null;
            }
            else return null;
        }

        //Updates left panel with list of VODs
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

        //Updates right panel with clips from selected VOD
        private void GetListViewClip(ClipCollection collection, ListView view)
        {
            ImageList largeImgList = new();
            ImageList smallImgList = new();
            largeImgList.ImageSize = new Size(256, 144);
            smallImgList.ImageSize = new Size(64, 36);
            largeImgList.ColorDepth = ColorDepth.Depth32Bit;
            smallImgList.ColorDepth = ColorDepth.Depth32Bit;
            List<ListViewItem> items = new();

            if (collection.data.Count != 0)
            {
                for (int i = 0; i < collection.data.Count; i++)
                {
                    Image img = collection.data[i].thumbnail;
                    largeImgList.Images.Add(img);
                    smallImgList.Images.Add(img);
                    string creatorName = collection.data[i].creator_name;
                    string title = collection.data[i].title;
                    string createdAt = collection.data[i].created_at.ToString("yyyy/MM/dd");
                    string offset = TimeSpan.FromSeconds(collection.data[i].vod_offset).ToString(@"hh\hmm\mss\s");
                    string length = collection.data[i].duration.ToString();
                    items.Add(new ListViewItem(new string[] { title, creatorName, createdAt, offset, length, "Preview" }, i));
                }
            }
            else MessageBox.Show("Selected VOD did not contain any clips.", "No Clips", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            view.Items.Clear();
            view.SmallImageList = smallImgList;
            view.LargeImageList = largeImgList;
            view.Items.AddRange(items.ToArray());
        }

        //Change the view type of the VOD list
        //private void viewDropDown_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (viewDropDown.SelectedItem)
        //    {
        //        case "Details":
        //            listView1.View = View.Details;
        //            break;
        //        case "Large Icon":
        //            listView1.View = View.LargeIcon;
        //            break;
        //        case "Small Icon":
        //            listView1.View = View.SmallIcon;
        //            break;
        //        case "List":
        //            listView1.View = View.List;
        //            break;
        //        case "Tile":
        //            listView1.View = View.Tile;
        //            break;
        //    }
        //}



        private async void submit_Click(object sender, EventArgs e)
        {
            id = await GetUserID(username.Text);
            if (id != null)
            {
                vodCol = new VODCollection();
                vodCol = await vodManager.UpdateVODCollection(id);
                GetListViewVOD(vodCol, listView1);
            }
        }
        private async void getClipsButton_Click(object sender, EventArgs e)
        {
            pb.Text = "Getting clips...";
            pb.Show(this);
            clipCol = new ClipCollection();
            VOD vod = vodCol.data[listView1.SelectedIndices[0]];
            int progress = 0;

            ClipCollection newClipCol = await clipManager.UpdateClipCollection(id, vod.created_at);
            foreach (Clip clip in newClipCol.data)
            {
                //Takes list of all clips created after specified date, removes the ones that don't match selected VOD
                if (clip.video_id == vod.id)
                {
                    clipCol.data.Add(clip);
                }
                pb.UpdateProgressBar(++progress * 25 / newClipCol.data.Count);
            }
            progress = 0;
            foreach (Clip clip in clipCol.data)
            {
                clip.thumbnail = await Program.LoadImage(clip.thumbnail_url, new Size(128, 72));
                pb.UpdateProgressBar(25 + (++progress * 75 / clipCol.data.Count));
            }
            await Task.Delay(500);
            pb.Hide();
            pb.UpdateProgressBar();
            GetListViewClip(clipCol, listView2);
        }
        private async void downloadButton_Click(object sender, EventArgs e)
        {
            var queue = new Queue<Clip>();
            var pathList = new List<string>();
            downloadTarget.ShowDialog();
            pb.Show(this);
            foreach (ListViewItem item in listView2.CheckedItems)
            {
                queue.Enqueue(clipCol.data[item.Index]);
                var path = Path.Combine(downloadTarget.SelectedPath, UserSettings.FormatFilename(clipCol.data[item.Index], Properties.Settings.Default.FilenameFormat));
                pathList.Add(path);
            }
            await Program.DownloadFileQueue(queue, pathList, pb);
            pb.Hide();
            pb.UpdateProgressBar();
        }
        private void preview_Click(object sender, ListViewColumnMouseEventArgs e)
        {
            Clip currentClip = clipCol.data[e.Item.Index];
            videoEmbed.Source = new Uri($@"http://localhost:3000/?id={currentClip.id}");
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
        private void authorizeButton_Click(object sender, EventArgs e)
        {
            form2 = new();
            form2.Show();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new();
            sf.Show();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            videoEmbed.Size = new Size(videoEmbed.Size.Height * 16 / 9, videoEmbed.Size.Height);
        }


        private void mainLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                columnStyles = mainLayout.ColumnStyles;
                resizing = true;
            }
        }

        private void mainLayout_MouseMove(object sender, MouseEventArgs e)
        {
            mainLayout.Capture = true;
            if (!resizing)
            {
                float width = 0;

                for (int i = 0; i < columnStyles.Count; i++)
                {
                    width += columnStyles[i].Width;
                    if (e.X > width - 3 && e.X < width + 3)
                    {
                        colIndex = i;
                        mainLayout.Cursor = Cursors.VSplit;
                        break;
                    }
                    else
                    {
                        colIndex = -1;
                        mainLayout.Cursor = Cursors.Default;
                        mainLayout.Capture = false;
                    }
                }
            }
            if (resizing && colIndex > -1)
            {
                float width = e.X;
                if (colIndex > -1)
                {
                    for (int i = 0; i < colIndex; i++)
                    {
                        width -= columnStyles[i].Width;
                    }
                    columnStyles[colIndex].SizeType = SizeType.Absolute;
                    columnStyles[colIndex].Width = width;
                }
            }
        }

        private void mainLayout_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                resizing = false;
                mainLayout.Cursor = Cursors.Default;
            }
        }
    }
}
