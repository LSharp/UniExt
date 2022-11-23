/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using System;

namespace UniExt
{
    public static class StringExtensions
    {
        public static bool _isNull(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static string _Crop(this string s, int c)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            var str = s;
            if (str.Length > c)
                str = str.Substring(0, c);

            return str;
        }

        public static string _Repeat(this string s, int r)
        {
            var str = string.Empty;
            for (int i = 0; i < r; i++)
                str += s;

            return str;
        }

        public static string _SaveToFile(this string s, string path)
        {
            System.IO.File.WriteAllText(path, s);
            return s;
        }

        public static string _Format(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static int _WordCount(this string str)
        {
            return str.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}