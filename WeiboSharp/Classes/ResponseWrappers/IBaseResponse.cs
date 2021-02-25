using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public interface IBaseResponse<T>
    {
        [JsonProperty("ok")]
        int Ok { get; set; }

        [JsonProperty("data")]
        T Data { get; set; }
    }
}
