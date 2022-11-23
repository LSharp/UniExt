/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using UnityEngine;

namespace UniExt
{
    public static class ColorExtensions
    {
        public static Color _SetAlpha(this Color c, float a)
        {
            return new Color(c.r, c.g, c.b, a);
        }

        public static string _ToCSS(this Color c)
        {
            Color32 col = c;
            return $"#{col.r:X2}{col.g:X2}{col.b:X2}";
        }
    }
}