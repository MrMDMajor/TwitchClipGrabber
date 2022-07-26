using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Twitch_Clip_Grabber
{
    static class Program
    {
        public static string Token { get; set; }
        public static string ClientId { get; set; }
        private static System.Timers.Timer timer = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Token = "agxsjiuosmnivrn8nl18ljp1gfapzi";
            ClientId = "gbt9qto8lnwyj7h1n70ixb7hivdba3";
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
                    //If thumbnail URL is broken/does not exist, things won't break
                    return Image.FromFile(@"resources\no_img.jpg");
                }
                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                { 
                    return Image.FromStream(responseStream);
                };
            }
            else return Image.FromFile(@"resources\no_img.jpg");
        }
        public static async Task DownloadFile(string url, string path)
        {
            var response = await Http.GetResponse(url, false);
            if (response.IsSuccessStatusCode)
            {
                using (FileStream fs = new FileStream(Path.Combine(url, path), FileMode.CreateNew))
                {
                    await response.Content.CopyToAsync(fs);
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
    }
}
