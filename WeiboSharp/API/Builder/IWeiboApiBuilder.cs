using System.Net.Http;
using WeiboSharp.Classes;
using WeiboSharp.Classes.Android.DeviceInfo;
using WeiboSharp.Classes.SessionHandlers;
using WeiboSharp.Logger;

namespace WeiboSharp.API.Builder
{
    public interface IWeiboApiBuilder
    {
        /// <summary>
        ///     Create new API instance
        /// </summary>
        /// <returns>API weibonce</returns>
        IWeiboApi Build();

        /// <summary>
        ///     Use custom logger
        /// </summary>
        /// <param name="logger">IWeiboLogger implementation</param>
        /// <returns>API Builder</returns>
        IWeiboApiBuilder UseLogger(IWeiboLogger logger);

        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>API Builder</returns>
        IWeiboApiBuilder UseHttpClient(HttpClient httpClient);

        /// <summary>
        ///     Set custom HttpClientHandler to be able to use certain features, e.g Proxy and so on
        /// </summary>
        /// <param name="handler">HttpClientHandler</param>
        /// <returns>API Builder</returns>
        IWeiboApiBuilder UseHttpClientHandler(HttpClientHandler handler);

        /// <summary>
        ///     Specify user login, password from here
        /// </summary>
        /// <param name="user">User auth data</param>
        /// <returns>API Builder</returns>
        IWeiboApiBuilder SetUser(UserSessionData user);

        /// <summary>
        ///     Set custom request message. Used to be able to customize device info.
        /// </summary>
        /// <param name="requestMessage">Custom request message object</param>
        /// <remarks>Please, do not use if you don't know what you are doing</remarks>
        /// <returns>API Builder</returns>
        IWeiboApiBuilder SetApiRequestMessage(ApiRequestMessage requestMessage);

        /// <summary>
        ///     Set delay between requests. Useful when API supposed to be used for mass-bombing.
        /// </summary>
        /// <param name="delay">Timespan delay</param>
        /// <returns>API Builder</returns>
        IWeiboApiBuilder SetRequestDelay(IRequestDelay delay);

        /// <summary>
        ///     Set Http request processor
        /// </summary>
        /// <param name="httpRequestProcessor">HttpRequestProcessor</param>
        /// <returns></returns>
        IWeiboApiBuilder SetHttpRequestProcessor(IHttpRequestProcessor httpRequestProcessor);

        /// <summary>
        ///     Set session handler
        /// </summary>
        /// <param name="sessionHandler">Session handler</param>
        /// <returns></returns>
        IWeiboApiBuilder SetSessionHandler(ISessionHandler sessionHandler);
    }
}