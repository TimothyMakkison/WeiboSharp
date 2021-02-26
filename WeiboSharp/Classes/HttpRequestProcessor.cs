using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeiboSharp.Classes.Android.DeviceInfo;
using WeiboSharp.Logger;

namespace WeiboSharp.Classes
{
    internal class HttpRequestProcessor : IHttpRequestProcessor
    {
        private IRequestDelay _delay;
        private readonly IWeiboLogger _logger;
        public IRequestDelay Delay { get { return _delay; } set { _delay = value; } }
        public HttpRequestProcessor(IRequestDelay delay, HttpClient httpClient, HttpClientHandler httpHandler,
            ApiRequestMessage requestMessage, IWeiboLogger logger)
        {
            _delay = delay;
            Client = httpClient;
            HttpHandler = httpHandler;
            RequestMessage = requestMessage;
            _logger = logger;
        }

        public HttpClientHandler HttpHandler { get; set; }
        public ApiRequestMessage RequestMessage { get; }
        public HttpClient Client { get; set; }
        public void SetHttpClientHandler(HttpClientHandler handler)
        {
            HttpHandler = handler;
            Client = new HttpClient(handler);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            requestMessage.Headers.Add("Connection", "Keep-Alive");
            LogHttpRequest(requestMessage);
            if (_delay.Exist)
                await Task.Delay(_delay.Value);
            var response = await Client.SendAsync(requestMessage);
            LogHttpResponse(response);
            return response;
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            _logger?.LogRequest(requestUri);
            if (_delay.Exist)
                await Task.Delay(_delay.Value);
            var response = await Client.GetAsync(requestUri);
            LogHttpResponse(response);
            return response;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage,
            HttpCompletionOption completionOption)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            requestMessage.Headers.Add("Connection", "Keep-Alive");
            LogHttpRequest(requestMessage);
            if (_delay.Exist)
                await Task.Delay(_delay.Value);
            var response = await Client.SendAsync(requestMessage, completionOption);
            LogHttpResponse(response);
            return response;
        }

        public async Task<string> SendAndGetJsonAsync(HttpRequestMessage requestMessage,
            HttpCompletionOption completionOption)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            LogHttpRequest(requestMessage);
            if (_delay.Exist)
                await Task.Delay(_delay.Value);
            var response = await Client.SendAsync(requestMessage, completionOption);
            LogHttpResponse(response);
            return await response.Content.ReadAsStringAsync();
        }

        //TODO implement DelayAsync 
        private async Task DelayAsync()
        {
            if (_delay.Exist)
                await Task.Delay(_delay.Value);
        }

        public async Task<string> GetJsonAsync(Uri requestUri)
        {
            Client.DefaultRequestHeaders.ConnectionClose = false;
            _logger?.LogRequest(requestUri);
            if (_delay.Exist)
                await Task.Delay(_delay.Value);
            var response = await Client.GetAsync(requestUri);
            LogHttpResponse(response);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<IResult<T>> Safe<T>(Func<IResult<T>> function)
        {
            try
            {
                return function();
            }
            catch (HttpRequestException httpException)
            {
                _logger?.LogException(httpException);
                return Result.Fail(httpException, default(T), ResponseType.NetworkProblem);
            }
            catch (Exception exception)
            {
                _logger?.LogException(exception);
                return Result.Fail<T>(exception);
            }
        }

        private void LogHttpRequest(HttpRequestMessage request)
        {
            _logger?.LogRequest(request);
        }

        private void LogHttpResponse(HttpResponseMessage request)
        {
            _logger?.LogResponse(request);
        }
    }
}