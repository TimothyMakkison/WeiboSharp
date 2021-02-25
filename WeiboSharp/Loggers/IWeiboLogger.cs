using System;
using System.Net.Http;

namespace WeiboSharp.Logger
{
    public interface IWeiboLogger
    {
        void LogRequest(HttpRequestMessage request);

        void LogRequest(Uri uri);

        void LogResponse(HttpResponseMessage response);

        void LogException(Exception exception);

        void LogInfo(string info);
    }
}