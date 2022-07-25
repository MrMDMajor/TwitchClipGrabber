using System;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Windows.Forms;

namespace Twitch_Clip_Grabber
{
    public class Http
    {
        public static HttpClient client = new HttpClient();
        private HttpListener Listener = null;

        public Http()
        {
            Listener = new HttpListener();
            Listener.Prefixes.Add("http://localhost:3000/");
            Listener.Start();
            Listener.BeginGetContext(GetContextCallback, null);

            client.BaseAddress = new Uri("https://api.twitch.tv/helix/");
        }

        private void GetContextCallback(IAsyncResult ar)
        {
            var context = Listener.EndGetContext(ar);

            Listener.BeginGetContext(GetContextCallback, null);
            var responseString = string.Format(File.ReadAllText(@".\login.html"));
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
