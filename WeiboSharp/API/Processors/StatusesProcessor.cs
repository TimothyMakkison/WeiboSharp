using System;
using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.Android.DeviceInfo;
using WeiboSharp.Classes.ResponseWrappers;
using WeiboSharp.Helpers;
using WeiboSharp.Logger;

namespace WeiboSharp.API.Processors
{
    internal class StatusesProcessor : IStatusesProcessor
    {
        private readonly AndroidDevice _deviceInfo;
        private readonly HttpHelper _httpHelper;
        private readonly IHttpRequestProcessor _httpRequestProcessor;
        private readonly WeiboApi _weiboApi;
        private readonly IWeiboLogger _logger;
        private readonly UserSessionData _user;
        private readonly UserAuthValidate _userAuthValidate;

        public StatusesProcessor(AndroidDevice deviceInfo,
                         HttpHelper httpHelper,
                         IHttpRequestProcessor httpRequestProcessor,
                         WeiboApi weiboApi,
                         IWeiboLogger logger,
                         UserSessionData user,
                         UserAuthValidate userAuthValidate)
        {
            _deviceInfo = deviceInfo;
            _httpHelper = httpHelper;
            _httpRequestProcessor = httpRequestProcessor;
            _weiboApi = weiboApi;
            _logger = logger;
            _user = user;
            _userAuthValidate = userAuthValidate;
        }

        /// <summary>
        /// Gets Weibo content (weibo post) by mid or id.
        /// </summary>
        /// <param name="identifier">Either alphanumeric mid or long id.</param>
        /// <returns></returns>
        public async Task<IResult<StatusShowResponse>> ShowStatusAsync(string identifier)
        {
            var url = string.Format(WeiboApiConstants.STATUS_GET_CONTENT, identifier);
            Uri uri = new Uri(url);

            var response = await _httpRequestProcessor.GetAsync(uri);
            return await response.ConvertResponseAsync<StatusShowResponse>();
        }
    }
}