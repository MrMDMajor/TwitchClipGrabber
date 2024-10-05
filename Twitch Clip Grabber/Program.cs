using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
        private static bool _isDownloading;
        public static bool isDownloading
        {
            get { return _isDownloading; }
            set
            {
                _isDownloading = value;
            }
        }
        private static int progress = 0;
        private static int queueStartCount = 0;
        private static Form1 form1;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            clipDownloader.IgnoreDownloadErrors = false;
            clipDownloader.OverwriteFiles = false;
            Utils.DownloadBinaries();

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
            form1 = Application.OpenForms["Form1"] as Form1;
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
                form1.busyInt++;
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
            form1.progressBar.Value = progress++ * 100 / queueStartCount;
            form1.progressLabel.Text = String.Format("Downloading Clips {0}/{1}", progress, queueStartCount);

            var outputPath = pathsQueue.Dequeue();
            if (File.Exists(outputPath))
            {
                outputPath = Append(outputPath);
            }

            var response = await clipDownloader.RunVideoDownload(
                current.url,
                overrideOptions: new OptionSet()
                {
                    Output = outputPath
                }
            );
            // TODO success check

            if (downloadQueue.Count > 1)
            {
                DequeueItem();
            }
            else
            {
                downloadQueue.Dequeue();
                isDownloading = false;
                progress = 0;
                queueStartCount = 0;
                form1.busyInt--;
                if (form1.busyInt == 0)
                {
                    //form1.progressStatusStrip.Visible = false;
                    form1.progressBar.Value = 0;
                    form1.progressBar.Visible = false;
                    form1.progressLabel.Text = "Download Completed";
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
    }
}
