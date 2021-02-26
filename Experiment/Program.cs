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
            string content = File.ReadAllText(@"C:\Users\timma\Desktop\http.txt");


            var api = WeiboApiBuilder.CreateBuilder()
                .UseLogger(new DebugLogger(LogLevel.Request))
                .Build();
            var user = api.ContainerProcessor
                .GetUserByIdAsync(id)
                ;
            var info = api.ContainerProcessor
                .GetUserInfoByIdAsync(id);
            var page = api.ContainerProcessor
                .GetUserPageById(id, 1);
            //var bid = page.Value.Cards[0].Mblog.Bid;

            Task.WaitAll(user, info, page);

            //page.Result.Value.Cards[0].Mblog.
        }
    }
}
