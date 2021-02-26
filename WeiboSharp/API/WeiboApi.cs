using System.Net.Http;
using System.Threading.Tasks;
using WeiboSharp.API.Processors;
using WeiboSharp.API.Versions;
using WeiboSharp.Classes;
using WeiboSharp.Classes.Android.DeviceInfo;
using WeiboSharp.Classes.SessionHandlers;
using WeiboSharp.Enums;
using WeiboSharp.Helpers;
using WeiboSharp.Logger;

namespace WeiboSharp.API
{
    public class WeiboApi : IWeiboApi
    {
        #region Variables and properties

        private IContainerProcessor _containerProcessor;

        private IRequestDelay _delay = RequestDelay.Empty();
        private readonly IHttpRequestProcessor _httpRequestProcessor;
        private readonly IProcessorHelper _processorHelper;
        private readonly IWeiboLogger _logger;
        private WeiboApiVersionType _apiVersionType;
        private WeiboApiVersion _apiVersion;
        private HttpHelper _httpHelper { get; set; }
        private AndroidDevice _deviceInfo;
        private UserSessionData _userSession;

        private UserSessionData _user
        {
            get { return _userSession; }
            set { _userSession = value; _userAuthValidate.User = value; }
        }

        private UserAuthValidate _userAuthValidate;
        private bool IsCustomDeviceSet = false;

        private string _waterfallIdReg = "", _deviceIdReg = "", _phoneIdReg = "", _guidReg = "";
        //InstaAccountRegistrationPhoneNumber _signUpPhoneNumberInfo;

        private bool _isUserAuthenticated;

        #region Constructor

        public WeiboApi(UserSessionData user, IWeiboLogger logger, AndroidDevice deviceInfo,
            IHttpRequestProcessor httpRequestProcessor)
        {
            _userAuthValidate = new UserAuthValidate();
            _user = user;
            _logger = logger;
            _deviceInfo = deviceInfo;
            _httpRequestProcessor = httpRequestProcessor;
            //_apiVersionType = apiVersionType;
            //_apiVersion = WeiboApiVersionList.GetApiVersionList().GetApiVersion(apiVersionType);
            _httpHelper = new HttpHelper(_apiVersion, httpRequestProcessor, this);
            _processorHelper = new ProcessorHelper(_logger);

            InitialiseProcessors();
        }

        #endregion Constructor

        public IContainerProcessor ContainerProcessor => _containerProcessor;

        /// <summary>
        ///     Indicates whether user authenticated or not
        /// </summary>
        public bool IsUserAuthenticated
        {
            get { return _isUserAuthenticated; }
            internal set { _isUserAuthenticated = value; _userAuthValidate.IsUserAuthenticated = value; }
        }

        /// <summary>
        ///     Current HttpClient
        /// </summary>
        public HttpClient HttpClient { get => _httpRequestProcessor.Client; }

        /// <summary>
        ///     Current <see cref="IHttpRequestProcessor"/>
        /// </summary>
        public IHttpRequestProcessor HttpRequestProcessor => _httpRequestProcessor;

        #endregion Variables and properties

        #region SessionHandler

        private ISessionHandler _sessionHandler;
        public ISessionHandler SessionHandler { get => _sessionHandler; set => _sessionHandler = value; }

        #endregion SessionHandler

        private void InitialiseProcessors()
        {
            _containerProcessor = new ContainerProcessor(_deviceInfo, _httpHelper, _httpRequestProcessor, this, _logger, _user, _userAuthValidate, _processorHelper);
        }

        public Task<IResult<InstaLoginResult>> LoginAsync(bool isNewLogin)
        {
            return Task.FromResult(Result.Fail<InstaLoginResult>("Not implemented"));
        }

        public void SetUser(string username, string password)
        {
            _user.UserName = username;
            _user.Password = password;

            _httpRequestProcessor.RequestMessage.Username = username;
            _httpRequestProcessor.RequestMessage.Password = password;
        }

        /// <summary>
        /// Sets user credentials
        /// </summary>
        public void SetUser(UserSessionData user)
        {
            SetUser(user.UserName, user.Password);
        }

        /// <summary>
        ///     Gets current device
        /// </summary>
        public AndroidDevice GetCurrentDevice()
        {
            return _deviceInfo;
        }

        /// <summary>
        ///     Gets logged in user
        /// </summary>
        public UserSessionData GetLoggedUser()
        {
            return _user;
        }

        ///// <summary>
        /////     Get currently logged in user info asynchronously
        ///// </summary>
        ///// <returns>
        /////     <see cref="T:InstagramApiSharp.Classes.Models.InstaCurrentUser" />
        ///// </returns>
        //public async Task<IResult<WeiboCurrentUser>> GetCurrentUserAsync()
        //{
        //    //ValidateUser();
        //    //ValidateLoggedIn();
        //    //return await _userProcessor.GetCurrentUserAsync();
        //}
    }
}