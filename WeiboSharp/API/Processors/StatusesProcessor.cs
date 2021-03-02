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
        private readonly IProcessorHelper _processorHelper;

        public StatusesProcessor(AndroidDevice deviceInfo,
                         HttpHelper httpHelper,
                         IHttpRequestProcessor httpRequestProcessor,
                         WeiboApi weiboApi,
                         IWeiboLogger logger,
                         UserSessionData user,
                         UserAuthValidate userAuthValidate,
                         IProcessorHelper processorHelper)
        {
            _deviceInfo = deviceInfo;
            _httpHelper = httpHelper;
            _httpRequestProcessor = httpRequestProcessor;
            _weiboApi = weiboApi;
            _logger = logger;
            _user = user;
            _userAuthValidate = userAuthValidate;
            _processorHelper = processorHelper;
        }

       
        public async Task<IResult<StatusShowResponse>> ShowStatusAsync(string identifier)
        {
            return await _processorHelper.HttpTryDo(async () =>
            {
                var url = string.Format(WeiboApiConstants.STATUS_GET_POST, identifier);
                Uri uri = new Uri(url);

                var response = await _httpRequestProcessor.GetAsync(uri);
                return await response.ConvertResponseAsBaseRespAsync<StatusShowResponse>();
            });
        }

        public async Task<IResult<StatusExtendedShowResponse>> ShowExtendedStatusAsync(string identifier)
        {
            return await _processorHelper.HttpTryDo(async () =>
            {
                var url = string.Format(WeiboApiConstants.STATUS_GET_EXTENDED_POST, identifier);
                Uri uri = new Uri(url);

                var response = await _httpRequestProcessor.GetAsync(uri);
                return await response.ConvertResponseAsync<StatusExtendedShowResponse>();
            });
        }
    }
}