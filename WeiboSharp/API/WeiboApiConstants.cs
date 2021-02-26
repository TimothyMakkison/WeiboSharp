using System;
using System.Collections.Generic;
using System.Text;

namespace WeiboSharp.API
{
    internal  static class WeiboApiConstants
    {
        public const string WEIBO_URL = "http://api.t.sina.com.cn/";

        // Container
        public const string CONTAINER_GET_USER = "https://m.weibo.cn/api/container/getIndex?containerid=100505{0}";
        public const string CONTAINER_GET_USER_INFO = "https://m.weibo.cn/api/container/getIndex?containerid=230283{0}_-_INFO";
        public const string CONTAINER_GET_USER_PAGE = "https://m.weibo.cn/api/container/getIndex?containerid=107603{0}&page={1}";

        //Statuses
        public const string STATUS_GET_CONTENT = "https://m.weibo.cn/statuses/show?id={0}";

        // Timeline

        // Weibo Access

        // User

        // Direct Message

        // Friendships

        // Trends

        // Social Graph

        // Privacy

        // Block

        // Tags

        // Account

        // Favorites

        // OAuth
    }
}
