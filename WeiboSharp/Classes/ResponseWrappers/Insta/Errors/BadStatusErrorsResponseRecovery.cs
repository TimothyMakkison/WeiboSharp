﻿using WeiboSharp.Classes.ResponseWrappers.InstaBaseResponse;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeiboSharp.Classes.ResponseWrappers
{
    public class BadStatusErrorsResponseRecovery : BaseStatusResponse
    {
        [JsonProperty("errors")] public MessageErrorsResponsePhone PhoneNumber { get; set; }
    }

    public class MessageErrorsResponsePhone
    {
        [JsonProperty("phone_number")] public List<string> Errors { get; set; }
    }

    public class MessageErrorsResponseRecoveryEmail : BaseStatusResponse
    {
        [JsonProperty("message")] public string Message { get; set; }
    }
}
