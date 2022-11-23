/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using UnityEngine;

namespace UniExt
{
    public static class Vector4Extensions
    {
        public static Vector4 Same(float xyzw)
        {
            return new Vector4(xyzw, xyzw, xyzw, xyzw);
        }

        public static Vector4 Same(int xyzw)
        {
            return new Vector4(xyzw, xyzw, xyzw);
        }
    }

    public static class Vector3Extensions
    {
        public static Vector3 Same(float xyz)
        {
            return new Vector3(xyz, xyz, xyz);
        }

        public static Vector3 Same(int xyz)
        {
            return new Vector3(xyz, xyz, xyz);
        }


        public static Vector3Int SameInt(int xyz)
        {
            return new Vector3Int(xyz, xyz, xyz);
        }
    }

    public static class Vector2Extensions
    {
        public static Vector2 Same(float xy)
        {
            return new Vector2(xy, xy);
        }

        public static Vector2 Same(int xy)
        {
            return new Vector2(xy, xy);
        }

        public static Vector2Int SameInt(int xy)
        {
            return new Vector2Int(xy, xy);
        }
    }
}