using System;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    static class Program
    {
        public static string Token { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Token = "zj9ofwslah1ly1jxvh7njqo6hcc7cx";
            string clientId = "gbt9qto8lnwyj7h1n70ixb7hivdba3";
            _ = new Http(Token, clientId);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
