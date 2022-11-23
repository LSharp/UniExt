/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using UnityEngine;

namespace UniExt
{
    public static class GameObjectExtensions
    {
        #region TRANSFORM

        public static Transform _tr(this GameObject go)
        {
            return go.transform;
        }

        #endregion TRANSFORM

        #region ACTIVE & PASSIVE

        public static GameObject _Active(this GameObject go)
        {
            go.SetActive(true);
            return go;
        }

        public static GameObject _Passive(this GameObject go)
        {
            go.SetActive(false);
            return go;
        }

        #endregion ACTIVE & PASSIVE

        #region GET,ADD & HAS COMPONENT

        public static T _Get<T>(this GameObject go) where T : Component
        {
            return go.GetComponent<T>();
        }

        public static T _Add<T>(this GameObject go) where T : Component
        {
            return go.AddComponent<T>();
        }

        public static T _GetOrAdd<T>(this GameObject go) where T : Component
        {
            var t = go.GetComponent<T>();
            return t != null ? t : go.AddComponent<T>();
        }

        public static bool _Has<T>(this GameObject go) where T : Component
        {
            return go.GetComponent<T>() != null;
        }

        #endregion GET,ADD & HAS COMPONENT
    }
}