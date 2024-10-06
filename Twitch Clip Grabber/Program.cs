using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;

namespace TwitchClipGrabber
{
    static class Program
    {
        private static System.Timers.Timer timer = new();
        private static YoutubeDL clipDownloader = new();
        private static Queue<Clip> downloadQueue = new();
        private static Queue<string> pathsQueue = new();
        private static List<string> failedDownloads = new();
        private static bool isFirstDownload = true;
        private static bool _isDownloading;
        public static bool isDownloading
        {
            get { return _isDownloading; }
            set
            {
                _isDownloading = value;
            }
        }
        private static int currentFileIndex = 0;
        private static int queueStartCount = 0;
        public static Form1 mainForm;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            clipDownloader.IgnoreDownloadErrors = false;
            clipDownloader.OverwriteFiles = false;

            _ = new Http();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static async Task<Image> LoadImage(string url, Size size)
        {
            if (url != "")
            {
                //VOD thumbnails do not have size specified, clip thumbnails are 480x272
                url = url.Replace("%{width}", size.Width.ToString()).Replace("%{height}", size.Height.ToString());
                var response = await Http.GetResponse(url, false);
                if (!response.IsSuccessStatusCode)
                {
                    return Properties.Resources.no_img;
                }
                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                {
                    return Image.FromStream(responseStream);
                }
            }
            else return Properties.Resources.no_img;
        }

        public static async Task AddToQueue(Queue<Clip> queue, Queue<string> paths)
        {
            if (isFirstDownload)
            {
                mainForm.progressBar.Value = 0;
                mainForm.progressLabel.Text = "Downloading Dependencies";
                try
                {
                    await Utils.DownloadBinaries();
                }
                catch
                {
                    MessageBox.Show("Failed to download dependencies. Please download yt-dlp and ffmpeg yourself from their respective sites, and place the .exe files in the same folder as this tool!");
                    return;
                }

                mainForm.progressLabel.Text = "Checking for Dependency Updates";
                try
                {
                    await clipDownloader.RunUpdate();
                }
                catch
                {
                    // ignore exception - if the update fails, we can still try to download clips with the old version
                }

                isFirstDownload = false;
            }

            queueStartCount += queue.Count;
            foreach (var clip in queue)
            {
                downloadQueue.Enqueue(clip);
            }
            foreach (var path in paths)
            {
                pathsQueue.Enqueue(path);
            }
            if (!isDownloading)
            {
                isDownloading = true;
                mainForm.busyInt++;
                await DownloadNext();
            }
        }

        private static async void DequeueItem()
        {
            downloadQueue.Dequeue();
            await DownloadNext();
        }

        private static async Task DownloadNext()
        {
            var current = downloadQueue.Peek();
            var totalSize = 0f;
            var sizeUnit = "";
            var progress = new Progress<DownloadProgress>(p => {
                if (totalSize == 0f)
                {
                    (totalSize, sizeUnit) = ParseDownloadSizeFromString(p.TotalDownloadSize);
                }
                else
                {
                    var progressValue = p.Progress > 0 ? (int)(p.Progress * 100) : mainForm.progressBar.Value;
                    mainForm.progressLabel.Text = String.Format("Downloading Clips {0}/{1}\n{2}/{3}", currentFileIndex, queueStartCount, (totalSize * progressValue / 100).ToString("F2"), totalSize + sizeUnit);
                    mainForm.progressBar.Value = progressValue;
                }
            });

            currentFileIndex++;
            var outputPath = pathsQueue.Dequeue();
            if (File.Exists(outputPath))
            {
                outputPath = Append(outputPath);
            }

            var response = await clipDownloader.RunVideoDownload(
                current.url,
                progress: progress,
                overrideOptions: new OptionSet()
                {
                    Output = outputPath,
                    Format = Properties.Settings.Default.DownloadQuality
                }
            );


            if (downloadQueue.Count > 1)
            {
                DequeueItem();
            }
            else if (downloadQueue.Count == 1)
            {
                downloadQueue.Dequeue();
                isDownloading = false;
                queueStartCount = 0;
                mainForm.busyInt--;
                if (mainForm.busyInt == 0)
                {
                    mainForm.progressBar.Value = 0;
                    mainForm.progressBar.Visible = false;
                    mainForm.progressLabel.Text = "Download Completed";

                    if (failedDownloads.Count > 0)
                    {
                        string message = String.Format("Download failed for {0} clip{1}:",
                                failedDownloads.Count, failedDownloads.Count == 1 ? "" : "s");
                        foreach (string c in failedDownloads)
                        {
                            message += "\n" + c;
                        }
                        MessageBox.Show(message);
                        failedDownloads.Clear();
                    }
                }
            }
        }

        public static void SetTimer(int length)
        {
            timer = new System.Timers.Timer(length);
            timer.AutoReset = false;
            timer.Elapsed += OnTimedEvent;
            timer.Start();
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Http.ValidateToken();
        }

        private static string Append(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string ext = Path.GetExtension(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string[] tokens = fileName.Split(new[] { '(' }, StringSplitOptions.None);

            int num = 0;
            int.TryParse(tokens.Last(), out num);
            string newPath;
            do
            {
                newPath = Path.Combine(dir, tokens.First() + '(' + (++num + 1) + ')' + ext);
            } while (File.Exists(newPath));
            return newPath;
        }

        private static (float, string) ParseDownloadSizeFromString(string input)
        {
            if (input != null)
            {
                var sizeString = new string(input.TakeWhile(c => char.IsDigit(c) || c == '.').ToArray());
                var unit = new string(input.SkipWhile(c => char.IsDigit(c) || c == '.').ToArray());

                if (float.TryParse(sizeString, out float size))
                {
                    return (size, unit.Trim());
                }
            }

            return (0f, "");
        }
    }
}
