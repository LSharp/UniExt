/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using System;

namespace UniExt
{
    public static class IntExtensions
    {
        public static int _Pow(this int i)
        {
            return i * i;
        }

        public static int _Add(this int i, int x, int times = 1)
        {
            return i + (x * times);
        }

        public static bool _IsBetween(this int i, int min, int max)
        {
            return i >= min && i <= max;
        }

        public static bool _BetweenExclude(this int i, int min, int max)
        {
            return i > min && i < max;
        }

        public static bool _IsInList(this int i, params int[] list)
        {
            return Array.IndexOf(list, i) > -1;
        }

        //TODO: int._Map
        /*
        public static int _Map(this int value, int fromSource, int toSource, int fromTarget, int toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
        */
    }
}