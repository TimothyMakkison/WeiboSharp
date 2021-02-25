using System;
using System.Net;
using WeiboSharp.Classes.Android.DeviceInfo;
using System.Collections.Generic;
using WeiboSharp.Enums;

namespace WeiboSharp.Classes
{
    [Serializable]
    public class StateData
    {
        public AndroidDevice DeviceInfo { get; set; }
        public UserSessionData UserSession { get; set; }
        public bool IsAuthenticated { get; set; }
        public CookieContainer Cookies { get; set; }
        public List<Cookie> RawCookies { get; set; }
        public WeiboApiVersionType? InstaApiVersion { get; set; }
    }
}