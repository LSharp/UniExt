/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using System;

namespace UniExt
{
    public static class DateTimeExtensions
    {
        public static int _ToUnixTimestamp(this DateTime date)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);
            var unixTimeSpan = date - unixEpoch;
            return (int)unixTimeSpan.TotalSeconds;
        }

        public static DateTime GetDateTimeFromUnixTime(ulong unixTime)
        {
            return GetDateTimeFromUnixTime((long)unixTime);
        }

        public static DateTime GetDateTimeFromUnixTime(long unixTime)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);
            return unixEpoch.AddSeconds(unixTime);
        }

        public static bool _IsExpired(this DateTime date, int hour)
        {
            return (DateTime.Now - date).TotalHours > hour;
        }

        public static string _ToFileName(this DateTime date, string prefix = "", string format = "yyyyMMdd_HHmmss")
        {
            return prefix + date.ToString(format);
        }

        public static string _ToFileName(string prefix = "", string format = "yyyyMMdd_HHmmss")
        {
            return prefix + DateTime.Now.ToString(format);
        }
    }
}