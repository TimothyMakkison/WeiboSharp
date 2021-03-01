using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WeiboSharp.API;
using WeiboSharp.API.Builder;

namespace WeiboSharpTest
{
    [TestClass]
    public class StatusesTests
    {
        private const string ID = "1831348402";
        private const string STATUS_BID = "JFKXA9Hq7";
        private const string EXPECTED_TITLE = "我被问到最多的一个问题是...";
        private IWeiboApi _api;

        public StatusesTests()
        {
            _api = WeiboApiBuilder.CreateBuilder().Build();
        }

        [TestMethod]
        public void TestGetStatus()
        {
            var post = _api.StatusesProcessor.ShowStatusAsync(STATUS_BID).Result.Value;
            var title = post.StatusTitle;
            var userId = post.User.Id;

            Assert.AreEqual(EXPECTED_TITLE, title);
            Assert.AreEqual(ID, userId.ToString());
        }
    }
}
