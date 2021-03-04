namespace WeiboSharp.API
{
    internal static class WeiboApiConstants
    {
        public const string WEIBO_URL = "http://api.t.sina.com.cn/";
        public const string BASE_M_URL = "https://m.weibo.cn/api";

        public const string CONTAINER = "/container";
        public const string STATUS = "/statuses";
        public const string COMMENTS = "/comments";

        // Container
        public const string CONTAINER_GET_USER = BASE_M_URL + CONTAINER + "/getIndex?containerid=100505{0}";

        public const string CONTAINER_GET_USER_INFO = BASE_M_URL + CONTAINER + "/getIndex?containerid=230283{0}_-_INFO";
        public const string CONTAINER_GET_USER_PAGE = BASE_M_URL + CONTAINER + "/getIndex?containerid=107603{0}&page={1}";

        //Statuses
        public const string STATUS_GET_POST = "https://m.weibo.cn/statuses/show?id={0}";
        public const string STATUS_GET_EXTENDED_POST = BASE_M_URL + STATUS + "/extend?id={0}";
        public const string STATUS_GET_REPOST_TIMELINE = BASE_M_URL + STATUS + "/repostTimeline?id={0}&page={1}";
        public const string STATUS_GET_POST_COMMENTS = BASE_M_URL + COMMENTS + "/show?id={0}&page={1}";

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