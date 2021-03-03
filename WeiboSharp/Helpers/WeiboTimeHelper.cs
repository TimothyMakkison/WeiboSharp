using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiboSharp.Helpers
{
    public static class WeiboTimeHelper
    {
        /// <summary>
        /// Converts a string of Weibo time format to Unix time.
        /// Weibo time format ie {Day of week, Month, Date, HH:MM:SS, UTC offset, Year}
        /// Example Wed Mar 03 15:52:09 +0800 2021
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static long WeiboTimeToUnix(string date)
        {
            // Split into 6 strings
            var split = date.Split().ToList();

            if (split.Count != 6)
                throw new ArgumentNullException();

            // Get final item - year and move to forth position
            var year = split.Last();
            split.Insert(3, year);
            split.RemoveAt(6);

            var valid = string.Join(" ", split);
            return DateTimeOffset.Parse(valid).ToUnixTimeSeconds();
        }
    }
}
