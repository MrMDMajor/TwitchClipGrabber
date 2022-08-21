using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchClipGrabber
{
    public partial class Form1 : Form
    {
        string id;
        bool busy = false;
        public int busyInt = 0;

        VODCollection vodCol;
        ClipCollection clipCol;

        VODManager vodManager = new();
        ClipManager clipManager = new();
        Form2 form2;

        public static ProgressBar pb = new();
        Queue<Clip> downloadQueue = new Queue<Clip>();

        bool resizing = false;
        bool inRange = false;
        TableLayoutColumnStyleCollection columnStyles;
        TableLayoutRowStyleCollection rowStyles;

        public Dictionary<string, int> vodDict;
        public Dictionary<string, int> clipDict;
        Dictionary<string, string> vodLookup = new Dictionary<string, string>()
        {
            {"Broadcaster", "user_name" },
            {"Date Created", "created_at" },
            {"Duration", "duration" },
            {"Title", "title" },
            {"URL", "url" },
            {"Views", "view_count" }
        };
        Dictionary<string, string> clipLookup = new Dictionary<string, string>()
        {
            {"Broadcaster", "broadcaster_name" },
            {"Creator", "creator_name" },
            {"Date Created", "created_at" },
            {"Duration", "duration" },
            {"ID", "id" },
            {"Title", "title" },
            {"URL", "url" },
            {"Views", "view_count" },
            {"VOD Date", "vod_date" },
            {"VOD Timestamp", "vod_offset" }
        };

        public Form1()
        {
            InitializeComponent();
            this.WindowState = (FormWindowState)Properties.Settings.Default.WindowState;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Reset();
            Http.ValidateToken();

            columnStyles = mainPanels.ColumnStyles;
            rowStyles = rightPanel.RowStyles;

            columnStyles[0].Width = Properties.Settings.Default.ColumnWidth;
            columnStyles[1].Width = 100 - Properties.Settings.Default.ColumnWidth;
            rowStyles[0].Height = Properties.Settings.Default.RowHeight;
            rowStyles[1].Height = 100 - Properties.Settings.Default.RowHeight;
            this.Size = Properties.Settings.Default.WindowSize;

            embedPanel_Resize(embedPanel, e);
            videoEmbed.EnsureCoreWebView2Async();

            UpdateListViews();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Properties.Settings.Default.WindowState = (int)this.WindowState;
                Properties.Settings.Default.ColumnWidth = columnStyles[0].Width;
                Properties.Settings.Default.RowHeight = rowStyles[0].Height;
                Properties.Settings.Default.WindowSize = this.Size;
                Properties.Settings.Default.Save();
            }
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
        private void GetListViewVOD()
        {
            ImageList largeImgList = new();
            ImageList smallImgList = new();
            largeImgList.ImageSize = new Size(256, 144);
            smallImgList.ImageSize = new Size(64, 36);
            largeImgList.ColorDepth = ColorDepth.Depth32Bit;
            smallImgList.ColorDepth = ColorDepth.Depth32Bit;
            List<ListViewItem> items = new();

            for (int i = 0; i < vodCol.data.Count; i++)
            {
                var vodAllFields = new Dictionary<string, string>();
                var vodSelectedFields = new List<string>();
                Image img = vodCol.data[i].thumbnail;
                largeImgList.Images.Add(img);
                smallImgList.Images.Add(img);
                foreach (var kvp in vodDict)
                {
                    var fields = vodCol.data[i].GetType().GetProperty(vodLookup[kvp.Key]).GetValue(vodCol.data[i]);
                    if (fields.GetType() == typeof(System.DateTime))
                    {
                        fields = ((DateTime)fields).ToString("yyyy/MM/dd");
                    }
                    vodAllFields.Add(kvp.Key, fields.ToString());
                }
                foreach (var k in Properties.Settings.Default.VODFields)
                {
                    vodSelectedFields.Add(vodAllFields[k]);
                }

                items.Add(new ListViewItem(vodSelectedFields.ToArray(), i));
            }
            listView1.Items.Clear();
            listView1.LargeImageList = largeImgList;
            listView1.SmallImageList = smallImgList;
            listView1.Items.AddRange(items.ToArray());
        }

        //Updates right panel with clips from selected VOD
        private void GetListViewClip()
        {
            ImageList largeImgList = new();
            ImageList smallImgList = new();
            largeImgList.ImageSize = new Size(256, 144);
            smallImgList.ImageSize = new Size(64, 36);
            largeImgList.ColorDepth = ColorDepth.Depth32Bit;
            smallImgList.ColorDepth = ColorDepth.Depth32Bit;
            List<ListViewItem> items = new();

            if (clipCol.data.Count != 0)
            {
                for (int i = 0; i < clipCol.data.Count; i++)
                {
                    var clipAllFields = new Dictionary<string, string>();
                    var clipSelectedFields = new List<string>();

                    Image img = clipCol.data[i].thumbnail;
                    largeImgList.Images.Add(img);
                    smallImgList.Images.Add(img);

                    foreach (var kvp in clipDict)
                    {
                        var field = this.clipCol.data[i].GetType().GetProperty(clipLookup[kvp.Key]).GetValue(clipCol.data[i]);
                        if (field.GetType() == typeof(System.DateTime))
                        {
                            field = ((DateTime)field).ToString("yyyy/MM/dd");
                        }
                        else if (kvp.Key == "VOD Timestamp")
                        {
                            field = TimeSpan.FromSeconds((int)field).ToString(@"h\hmm\mss\s");
                        }
                        else if (kvp.Key == "Duration")
                        {
                            field = string.Concat(field.ToString(), "s");
                        }
                        clipAllFields.Add(kvp.Key, field.ToString());
                    }
                    foreach (var k in Properties.Settings.Default.ClipFields)
                    {
                        clipSelectedFields.Add(clipAllFields[k]);
                    }
                    items.Add(new ListViewItem(clipSelectedFields.ToArray(), i));
                }
            }
            else MessageBox.Show("Selected VOD did not contain any clips.", "No Clips", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            listView2.Items.Clear();
            listView2.SmallImageList = smallImgList;
            listView2.LargeImageList = largeImgList;
            listView2.Items.AddRange(items.ToArray());
        }

        public void UpdateListViews()
        {
            vodDict = JsonSerializer.Deserialize<Dictionary<string, int>>(Properties.Settings.Default.VODDictionary);
            clipDict = JsonSerializer.Deserialize<Dictionary<string, int>>(Properties.Settings.Default.ClipDictionary);

            listView1.Columns.Clear();
            listView2.Columns.Clear();
            foreach (var i in Properties.Settings.Default.VODFields)
            {
                listView1.Columns.Add(i, vodDict[i]);
            }
            foreach (var i in Properties.Settings.Default.ClipFields)
            {
                listView2.Columns.Add(i, clipDict[i]);
            }

            if (vodCol != null) GetListViewVOD();
            if (clipCol != null) GetListViewClip();
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
                vodCol = await vodManager.UpdateVODCollection(id, this);
                GetListViewVOD();
            }
        }
        private async void getClipsButton_Click(object sender, EventArgs e)
        {
            if (vodCol != null && !busy)
            {
                busy = true;
                busyInt++;
                progressStatusStrip.Visible = true;
                progressLabel.Text = "Getting Clips...  0%";

                clipCol = new ClipCollection();
                VOD vod = vodCol.data[listView1.SelectedIndices[0]];
                int progress = 0;

                ClipCollection newClipCol = await clipManager.UpdateClipCollection(id, vod.created_at);
                Console.WriteLine(newClipCol.data[0].title);
                foreach (Clip clip in newClipCol.data)
                {
                    //Takes list of all clips created after specified date, removes the ones that don't match selected VOD
                    if (clip.video_id == vod.id)
                    {
                        clipCol.data.Add(clip);
                    }

                    progressBar.Value = ++progress * 25 / newClipCol.data.Count;
                    progressLabel.Text = String.Format("Getting Clips...  {0}%", progressBar.Value);
                }
                progress = 0;
                foreach (Clip clip in clipCol.data)
                {
                    clip.thumbnail = await Program.LoadImage(clip.thumbnail_url, new Size(128, 72));

                    progressBar.Value = 25 + (++progress * 75 / clipCol.data.Count);
                    progressLabel.Text = String.Format("Getting Clips...  {0}%", progressBar.Value);
                }
                await Task.Delay(500);
                busyInt--;
                if (busyInt == 0)
                {
                    progressStatusStrip.Visible = false;
                    progressBar.Value = 0;
                    progressLabel.Text = "";
                }
                GetListViewClip();
                busy = false;
            }
        }
        private async void downloadButton_Click(object sender, EventArgs e)
        {
            var pathList = new List<string>();
            downloadTarget.ShowDialog();
            progressStatusStrip.Visible = true;
            busyInt++;
            foreach (ListViewItem item in listView2.CheckedItems)
            {

                downloadQueue.Enqueue(clipCol.data[item.Index]);
                var path = Path.Combine(downloadTarget.SelectedPath, UserSettings.FormatFilename(clipCol.data[item.Index], Properties.Settings.Default.FilenameFormat));
                pathList.Add(path);
            }
            await Program.DownloadFileQueue(downloadQueue, pathList, this);
            busyInt--;
            if (busyInt == 0)
            {
                progressStatusStrip.Visible = false;
                progressBar.Value = 0;
                progressLabel.Text = "";
            }
        }
        private void preview_Click(object sender, EventArgs e)
        {
            if (clipCol != null && listView2.SelectedItems.Count > 0)
            {
                Clip currentClip = clipCol.data[listView2.SelectedIndices[0]];
                videoEmbed.Source = new Uri($@"http://localhost:3000/?id={currentClip.id}"); 
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
        private void embedPanel_Resize(object sender, EventArgs e)
        {
            var panel = sender as TableLayoutPanel;
            if (panel.Width < panel.Height)
            {
                videoEmbed.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                videoEmbed.Height = videoEmbed.Width * 9 / 16;
            }
            else
            {
                videoEmbed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                videoEmbed.Width = videoEmbed.Height * 16 / 9;
            }
        }
        private void mainPanels_MouseDown(object sender, MouseEventArgs e)
        {
            var thisPanel = (TableLayoutPanel)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                columnStyles = thisPanel.ColumnStyles;
                resizing = true;
            }
        }
        private void mainPanels_MouseMove(object sender, MouseEventArgs e)
        {
            var thisPanel = (TableLayoutPanel)sender;
            float x = e.X * 100f / thisPanel.Width;
            thisPanel.Capture = true;
            if (!resizing)
            {
                float width = columnStyles[0].Width;
                var range = 300f / thisPanel.Width;
                if (x > width - range && x < width + range)
                {
                    thisPanel.Cursor = Cursors.VSplit;
                    inRange = true;
                }
                else
                {
                    thisPanel.Cursor = Cursors.Default;
                    thisPanel.Capture = false;
                }
            }
            if (resizing && inRange)
            {
                columnStyles[0].Width = x;
                columnStyles[1].Width = 100 - x;
            }
        }
        private void mainPanels_MouseUp(object sender, MouseEventArgs e)
        {
            var thisPanel = (TableLayoutPanel)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                resizing = false;
                thisPanel.Cursor = Cursors.Default;
            }
        }
        private void mainPanels_MouseLeave(object sender, EventArgs e)
        {
            var thisPanel = (TableLayoutPanel)sender;
            thisPanel.Capture = false;
            thisPanel.Cursor = Cursors.Default;
        }
        private void rightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var thisPanel = (TableLayoutPanel)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                rowStyles = thisPanel.RowStyles;
                resizing = true;
            }
        }
        private void rightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var thisPanel = (TableLayoutPanel)sender;
            float y = e.Y * 100f / thisPanel.Height;
            thisPanel.Capture = true;
            if (!resizing)
            {
                float height = rowStyles[0].Height;
                var range = 300f / thisPanel.Height;
                if (y > height - range && y < height + range)
                {
                    thisPanel.Cursor = Cursors.HSplit;
                    inRange = true;
                }
                else
                {
                    thisPanel.Cursor = Cursors.Default;
                    thisPanel.Capture = false;
                }
            }
            if (resizing && inRange)
            {
                rowStyles[0].Height = y;
                rowStyles[1].Height = 100 - y;
            }
        }
        private void listView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            var senderListView = sender as ListView;
            var chosenDict = senderListView.Name == "listView1" ? vodDict : clipDict;
            if (chosenDict != null)
            {
                chosenDict[senderListView.Columns[e.ColumnIndex].Text] = senderListView.Columns[e.ColumnIndex].Width;
                if (senderListView.Name == "listView1")
                {
                    Properties.Settings.Default.VODDictionary = JsonSerializer.Serialize<Dictionary<string, int>>(chosenDict);
                }
                else
                {
                    Properties.Settings.Default.ClipDictionary = JsonSerializer.Serialize<Dictionary<string, int>>(chosenDict);
                }
            }
            Properties.Settings.Default.Save();
        }
    }
}
