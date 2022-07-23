using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    static class Program
    {
        public static string Token { get; set; }
        public static string ClientId { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Token = "agxsjiuosmnivrn8nl18ljp1gfapzi";
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
                url = url.Replace("%{width}", size.Width.ToString()).Replace("%{height}", size.Height.ToString());
                var response = await Http.GetResponse(url, false);
                if (!response.IsSuccessStatusCode)
                {
                    return Image.FromFile(@"resources\no_img.jpg");
                }
                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                { 
                    return Image.FromStream(responseStream);
                };
            }
            else return Image.FromFile(@"resources\no_img.jpg");
        }
        public static async void DownloadFile(string url, string path)
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
    }
}
