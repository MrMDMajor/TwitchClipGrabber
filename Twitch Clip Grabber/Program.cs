using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TwitchClipGrabber
{
    static class Program
    {
        private static System.Timers.Timer timer = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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
        public static async Task DownloadFileQueue(Queue<Clip> queue, List<string> paths, Form1 form)
        {
            var newPaths = new List<string>();
            newPaths = paths.Select(fn => AppendDuplicates(fn, newPaths, " (")).ToList();

            int startLength = queue.Count;
            int progress = 0;

            while (queue.Count != 0)
            {
                var currentClip = queue.Dequeue();
                var response = await Http.GetResponse(currentClip.download_url, false);
                if (response.IsSuccessStatusCode)
                {
                    using (FileStream fs = File.Create(newPaths[progress] + ".mp4"))
                    {
                        await response.Content.CopyToAsync(fs);
                    }
                }
                form.progressBar.Value = ++progress * 100 / startLength;
                form.progressLabel.Text = string.Format("Downloading...  {0}/{1}", progress, startLength);
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

        private static string AppendDuplicates(string path, List<string> pathList, string separator)
        {
            string dir = Path.GetDirectoryName(path);
            string ext = Path.GetExtension(path);
            string fileName = Path.GetFileName(path);
            string[] tokens = fileName.Split(new[] { separator }, StringSplitOptions.None);

            int num = 0;
            int.TryParse(tokens.Last(), out num);

            var dupes = pathList.Where(n => n.Equals(path, StringComparison.OrdinalIgnoreCase));
            while (dupes.Any())
            {
                path = Path.Combine(dir, tokens.First() + separator + (++num + 1) + ")" + ext);
            }
            pathList.Add(path);
            return path;
        }
    }
}
