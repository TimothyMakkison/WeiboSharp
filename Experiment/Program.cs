using System;
using WeiboSharp.API;
using WeiboSharp.API.Builder;
using System.Collections.Generic;
using WeiboSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using System.IO;
using WeiboSharp.Logger;
using System.Threading.Tasks;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "1669879400";
            string postId = "4154099588849643";


            var api = WeiboApiBuilder.CreateBuilder()
                .UseLogger(new DebugLogger(LogLevel.Request))
                .Build();
            var user = api.ContainerProcessor
                .GetUserByIdAsync(id);
            var info = api.ContainerProcessor
                .GetUserInfoByIdAsync(id);
            var page = api.ContainerProcessor
               .GetUserPageAsync(id, 1);

            var status = api.StatusesProcessor
                .ShowStatusAsync(postId);

            var post = api.StatusesProcessor.ShowExtendedStatusAsync("JFKXA9Hq7");


            Task.WaitAll(user, info, page, status, post);
        }
    }
}
