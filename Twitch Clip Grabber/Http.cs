﻿using System;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;

namespace Twitch_Clip_Grabber
{
    public class Http
    {
        public static HttpClient client = new HttpClient();
        private HttpListener Listener = null;

        public Http(string token, string clientId)
        {
            Listener = new HttpListener();
            Listener.Prefixes.Add("http://localhost:3000/");
            Listener.Start();
            Listener.BeginGetContext(GetContextCallback, null);

            client.BaseAddress = new Uri("https://api.twitch.tv/helix/");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.DefaultRequestHeaders.Add("Client-Id", clientId);

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
    }
}
