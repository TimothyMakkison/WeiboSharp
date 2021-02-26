using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.Android.DeviceInfo;
using WeiboSharp.Classes.ResponseWrappers;
using WeiboSharp.Classes.ResponseWrappers.Container;
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

        public ContainerProcessor(AndroidDevice deviceInfo,
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

        public async Task<IResult<UserResponse>> GetUserByIdAsync(string uid)
        {
            var url = string.Format(WeiboApiConstants.CONTAINER_GET_USER, uid);
            Uri uri = new Uri(url);

            var response = await _httpRequestProcessor.GetAsync(uri);
            //using (Stream resStream = await response.Content.ReadAsStreamAsync())
            //{
            //    StreamReader reader = new StreamReader(resStream, Encoding.UTF8);
            //    return Result.Success(reader.ReadToEnd());
            //}
            return await response.ConvertResponseAsync<UserResponse>();
        }

        public async Task<IResult<ContainerUserInfoData>> GetUserInfoByIdAsync(string uid)
        {
            var url = string.Format(WeiboApiConstants.CONTAINER_GET_USER_INFO, uid);
            Uri uri = new Uri(url);

            var response = await _httpRequestProcessor.GetAsync(uri);
            var content = await response.Content.ReadAsByteArrayAsync();

            var ut = Encoding.UTF8.GetString(content);

            var info = JsonConvert.DeserializeObject<BaseResponse<ContainerUserInfoData>>(ut);
            return Result.Success(info.Data);
        }

        public async Task<IResult<PageData>> GetUserPageById(string uid, int page)
        {
            var url = string.Format(WeiboApiConstants.CONTAINER_GET_USER_PAGE, uid, page);
            Uri uri = new Uri(url);

            var response = await _httpRequestProcessor.GetAsync(uri);
           
            return await response.ConvertResponseAsync<PageData>();
        }
    }
}