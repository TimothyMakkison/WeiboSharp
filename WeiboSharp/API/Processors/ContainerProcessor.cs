using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.Android.DeviceInfo;
using WeiboSharp.Classes.ResponseWrappers;
using WeiboSharp.Helpers;
using WeiboSharp.Logger;

namespace WeiboSharp.API.Processors
{
    internal class ContainerProcessor : IContainerProcessor
    {
        private readonly AndroidDevice _deviceInfo;
        private readonly HttpHelper _httpHelper;
        private readonly IHttpRequestProcessor _httpRequestProcessor;
        private readonly WeiboApi _weiboApi;
        private readonly IWeiboLogger _logger;
        private readonly UserSessionData _user;
        private readonly UserAuthValidate _userAuthValidate;
        private readonly IProcessorHelper _processorHelper;

        public ContainerProcessor(AndroidDevice deviceInfo,
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

        public async Task<IResult<ContainerUserResponse>> GetUserByIdAsync(string uid)
        {
            return await _processorHelper.HttpTryDo(async () =>
            {
                var url = string.Format(WeiboApiConstants.CONTAINER_GET_USER, uid);
                Uri uri = new Uri(url);

                var response = await _httpRequestProcessor.GetAsync(uri);
                return await response.ConvertResponseAsync<ContainerUserResponse>();
            });
        }

        public async Task<IResult<ContainerInfoResponse>> GetUserInfoByIdAsync(string uid)
        {
            return await _processorHelper.HttpTryDo(async () =>
            {
                var url = string.Format(WeiboApiConstants.CONTAINER_GET_USER_INFO, uid);
                Uri uri = new Uri(url);

                var response = await _httpRequestProcessor.GetAsync(uri);
                var content = await response.Content.ReadAsStringAsync();
                return await response.ConvertResponseAsync<ContainerInfoResponse>();
            });
        }

        public async Task<IResult<ContainerPageResponse>> GetUserPageById(string uid, int page)
        {
            return await _processorHelper.HttpTryDo(async () =>
            {
                var url = string.Format(WeiboApiConstants.CONTAINER_GET_USER_PAGE, uid, page);
                Uri uri = new Uri(url);

                var response = await _httpRequestProcessor.GetAsync(uri);
                return await response.ConvertResponseAsync<ContainerPageResponse>();
            });
        }
    }
}