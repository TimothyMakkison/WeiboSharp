using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;

namespace WeiboSharp.Helpers
{
    public static class HttpExtensions
    {
        public static Uri AddQueryParameter(this Uri uri, string name, string value)
        {
            if (value == null || value == "" || value == "[]") return uri;
            var httpValueCollection = HttpUtility.ParseQueryString(uri);

            httpValueCollection.Remove(name);
            httpValueCollection.Add(name, value);

            var ub = new UriBuilder(uri);
            var q = "";
            foreach (var item in httpValueCollection)
            {
                if (q == "") q += $"{item.Key}={item.Value}";
                else q += $"&{item.Key}={item.Value}";
            }
            ub.Query = q;
            return ub.Uri;
        }

        public static Uri AddQueryParameterIfNotEmpty(this Uri uri, string name, string value)
        {
            if (value == null || value == "" || value == "[]") return uri;

            var httpValueCollection = HttpUtility.ParseQueryString(uri);
            httpValueCollection.Remove(name);
            httpValueCollection.Add(name, value);
            var ub = new UriBuilder(uri);
            var q = "";
            foreach (var item in httpValueCollection)
            {
                if (q == "") q += $"{item.Key}={item.Value}";
                else q += $"&{item.Key}={item.Value}";
            }
            ub.Query = q;
            return ub.Uri;
        }

        //TODO Create TryConvert - takes response and T and tries to convert response content to T if status is Ok
        public async static Task<IResult<T>> ConvertResponseAsync<T>(this HttpResponseMessage httpResponse)
        {
            if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<BaseResponse<T>>(content);

                return value.Ok == 1 ? Result.Success(value.Data) :
                    Result.Fail<T>($"Status code returned OK but content returned fail with the values:" +
                    $"\n ok: {value.Ok}, msg: {value.Message}");
            }
            return Result.Fail<T>("Did not respond with okay");
        }
    }
}