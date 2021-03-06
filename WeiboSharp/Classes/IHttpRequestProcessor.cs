﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeiboSharp.Classes.Android.DeviceInfo;

namespace WeiboSharp.Classes
{
    public interface IHttpRequestProcessor
    {
        HttpClientHandler HttpHandler { get; set; }
        ApiRequestMessage RequestMessage { get; }
        HttpClient Client { get; }

        void SetHttpClientHandler(HttpClientHandler handler);

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage);

        Task<HttpResponseMessage> GetAsync(Uri requestUri);

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, HttpCompletionOption completionOption);

        Task<string> SendAndGetJsonAsync(HttpRequestMessage requestMessage, HttpCompletionOption completionOption);

        Task<string> GetJsonAsync(Uri requestUri);

        Task<string> GetFileAsync(Uri requestUri, string filePath);


        IRequestDelay Delay { get; set; }
    }
}