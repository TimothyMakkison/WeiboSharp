using System;
using WeiboSharp.API;
using WeiboSharp.API.Builder;
using System.Collections.Generic;
using WeiboSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using System.IO;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string id = "2302831669879400";
            string content = File.ReadAllText(@"C:\Users\timma\Desktop\http.txt");


            var a = WeiboApiBuilder.CreateBuilder().Build();
            var user = a.ContainerProcessor.GetUserByIdAsync(id).Result;
            var info = a.ContainerProcessor.GetUserInfoByIdAsync(id).Result;

            var b = JsonConvert.DeserializeObject<BaseResponse<object>>(content);
        }
    }
}
