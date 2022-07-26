using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void browser_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string regex = @"http://localhost/#access_token=(.*?)&";
            if (Regex.IsMatch(browser.Source.ToString(), regex))
            {
                string token = Regex.Match(browser.Source.ToString(), regex).Groups[1].ToString();
                Properties.Settings.Default.Token = token;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}