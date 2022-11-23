/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using System;

namespace UniExt
{
    public static class FloatExtensions
    {
        public static float _Pow(this float f)
        {
            return f * f;
        }

        public static bool _IsNAN(this float f)
        {
            return float.IsNaN(f);
        }

        public static float _Add(this float f, float x, int times = 1)
        {
            return f + (x * times);
        }

        public static bool _IsBetween(this float f, float min, float max)
        {
            return f >= min && f <= max;
        }

        public static bool _BetweenExclude(this float f, float min, float max)
        {
            return f > min && f < max;
        }

        public static bool _IsInList(this float f, params float[] list)
        {
            return Array.IndexOf(list, f) > -1;
        }

        public static float _Map(this float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
    }
}