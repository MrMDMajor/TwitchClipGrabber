using System;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace TwitchClipGrabber
{
    public class Http
    {
        public static HttpClient client = new HttpClient();
        private HttpListener Listener = null;

        public Http()
        {
            Ping ping = new Ping();

            try { ping.Send(new IPAddress(134744072)); }
            catch
            {
                if (MessageBox.Show("No internet connection. Please connect to the internet and relaunch program.", "No internet connection", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            Listener = new HttpListener();
            Listener.Prefixes.Add("http://localhost:3000/");
            Listener.Prefixes.Add("http://localhost:3000/login/");
            Listener.Start();
            Listener.BeginGetContext(GetContextCallback, null);
            client.BaseAddress = new Uri("https://api.twitch.tv/helix/");
        }

        private void GetContextCallback(IAsyncResult ar)
        {
            var context = Listener.EndGetContext(ar);
            Listener.BeginGetContext(GetContextCallback, null);
            var responseString = "";
            if (context.Request.RawUrl == "/login") responseString = string.Format(File.ReadAllText(@".\login.html"));
            else responseString = string.Format(File.ReadAllText(@".\embed.html"), context.Request.QueryString["id"]);
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            var response = context.Response;
            response.ContentType = "text/html";
            response.ContentLength64 = buffer.Length;
            response.StatusCode = 200;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }

        public static async Task<HttpResponseMessage> GetResponse(string url, bool attachHeaders)
        {
            if (Properties.Settings.Default.Token == "" || Properties.Settings.Default.Token == null)
            {
                MessageBox.Show("No valid token, please authenticate");
            }

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            if (attachHeaders)
            {
                request.Headers.Add("Authorization", "Bearer " + Properties.Settings.Default.Token);
                request.Headers.Add("Client-Id", Program.ClientId);
            }
            var response = await client.SendAsync(request);
            return response;
        }

        public static bool ValidateToken()
        {
            string url = "https://id.twitch.tv/oauth2/validate";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", "OAuth " + Properties.Settings.Default.Token);
            var response = client.Send(request);
            if (!response.IsSuccessStatusCode)
            {
                Properties.Settings.Default.Token = "";
                Properties.Settings.Default.Save();
            }
            else Program.SetTimer(3600000);
            return response.IsSuccessStatusCode;
        }
    }
}
