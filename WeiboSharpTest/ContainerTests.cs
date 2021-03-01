using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WeiboSharp.API;
using WeiboSharp.API.Builder;

namespace WeiboSharpTest
{
    [TestClass]
    public class ContainerTests
    {
        private const string ID = "1831348402";
        private IWeiboApi _api;

        public ContainerTests()
        {
            _api = WeiboApiBuilder.CreateBuilder().Build();
        }

        [TestMethod]
        public void TestGetUserByIdByAsyc()
        {
            var user = _api.ContainerProcessor.GetUserByIdAsync(ID).Result;
            var name = user.Value.UserInfo.ScreenName;
            Assert.AreEqual(name, "比尔盖茨");
        }
        [TestMethod]
        public void TestGetUserInfoByIdByAsyc()
        {
            var user = _api.ContainerProcessor.GetUserInfoByIdAsync(ID).Result;
            Assert.IsTrue(user.Value.Cards.Count > 0);
        }
    }
}
