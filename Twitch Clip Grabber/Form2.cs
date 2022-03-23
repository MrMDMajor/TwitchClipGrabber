using System;
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

        private void load_Click(object sender, EventArgs e)
        {
            browser.CoreWebView2.Navigate("http://localhost:3000");
        }

        private void browser_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string regex = @"http://localhost/#access_token=(.*?)&";
            if (Regex.IsMatch(browser.Source.ToString(), regex))
            {
                string token = Regex.Match(browser.Source.ToString(), regex).Groups[1].ToString();
                this.Close();
            }
        }
    }
}
