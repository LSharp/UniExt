/*
 * Created on 23 November 2022
 * Copyright (c) by LSharp (https://github.com/LSharp)
 */

using UnityEngine;

namespace UniExt
{
    public static class TransformExtensions
    {
        #region GAMEOBJECT

        public static GameObject _go(this Transform tr)
        {
            return tr.gameObject;
        }

        #endregion

        #region ACTIVE & PASSIVE

        public static Transform _Active(this Transform tr)
        {
            tr.gameObject.SetActive(true);
            return tr;
        }

        public static Transform _Passive(this Transform tr)
        {
            tr.gameObject.SetActive(false);
            return tr;
        }

        #endregion

        #region GET,ADD & HAS COMPONENT  

        public static T _Get<T>(this Transform tr) where T : Component
        {
            return tr.GetComponent<T>();
        }

        public static T _Add<T>(this Transform tr) where T : Component
        {
            return tr._go().AddComponent<T>();
        }

        public static T _GetOrAdd<T>(this Transform tr) where T : Component
        {
            var t = tr.GetComponent<T>();
            return t != null ? t : tr._go().AddComponent<T>();
        }

        public static bool _Has<T>(this Transform tr) where T : Component
        {
            return tr.GetComponent<T>() != null;
        }

        #endregion

        #region POSITON

        #region SET POSITON

        public static Transform _SetLocalPos(this Transform t, Vector3 v3)
        {
            t.localPosition = v3;
            return t;
        }


        public static Transform _SetLocalPos(this Transform t, float x, float y, float z)
        {
            return t._SetLocalPos(new Vector3(x, y, z));
        }


        public static Transform _SetLocalPos(this Transform t, float xyz)
        {
            t.localPosition = new Vector3(xyz, xyz, xyz);
            return t;
        }

        public static Transform _SetLocalPosXY(this Transform t, float x, float y)
        {
            return t._SetLocalPos(new Vector3(x, y, t.localPosition.z));
        }

        public static Transform _SetLocalPosX(this Transform t, float x)
        {
            var locPos = t.localPosition;
            return t._SetLocalPos(new Vector3(x, locPos.y, locPos.z));
        }

        public static Transform _SetLocalPosY(this Transform t, float y)
        {
            var locPos = t.localPosition;
            return t._SetLocalPos(new Vector3(locPos.x, y, locPos.z));
        }

        public static Transform _SetLocalPosZ(this Transform t, float z)
        {
            var locPos = t.localPosition;
            return t._SetLocalPos(new Vector3(locPos.x, locPos.y, z));
        }

        public static Transform _SetPos(this Transform t, Vector3 v3)
        {
            t.position = v3;
            return t;
        }

        public static Transform _SetPos(this Transform t, float x, float y, float z)
        {
            return t._SetPos(new Vector3(x, y, z));
        }

        public static Transform _SetPos(this Transform t, float xyz)
        {
            return t._SetPos(new Vector3(xyz, xyz, xyz));
        }

        public static Transform _SetPosXY(this Transform t, float x, float y)
        {
            return t._SetPos(new Vector3(x, y, t.position.z));
        }

        public static Transform _SetPosX(this Transform t, float x)
        {
            var pos = t.position;
            return t._SetPos(new Vector3(x, pos.y, pos.z));
        }

        public static Transform _SetPosY(this Transform t, float Y)
        {
            var pos = t.position;
            return t._SetPos(new Vector3(pos.x, Y, pos.z));
        }

        public static Transform _SetPosZ(this Transform t, float Z)
        {
            var pos = t.position;
            return t._SetPos(new Vector3(pos.x, pos.y, Z));
        }

        #endregion SET POSITON

        #region ADD TO POSITION

        public static Transform _AddLocalPos(this Transform t, Vector3 v3)
        {
            t.localPosition += v3;
            return t;
        }

        public static Transform _AddLocalPos(this Transform t, float x, float y, float z)
        {
            return t._AddLocalPos(new Vector3(x, y, z));
        }

        public static Transform _AddLocalPosXY(this Transform t, float x, float y)
        {
            return t._AddLocalPos(new Vector3(x, y, 0f));
        }

        public static Transform _AddLocalPosX(this Transform t, float x)
        {
            return t._AddLocalPos(new Vector3(x, 0f, 0f));
        }

        public static Transform _AddLocalPosY(this Transform t, float y)
        {
            return t._AddLocalPos(new Vector3(0f, y, 0f));
        }

        public static Transform _AddLocalPosZ(this Transform t, float z)
        {
            return t._AddLocalPos(new Vector3(0f, 0f, z));
        }

        public static Transform _AddPos(this Transform t, Vector3 v3)
        {
            t.position += v3;
            return t;
        }

        public static Transform _AddPos(this Transform t, float x, float y, float z)
        {
            return t._AddPos(new Vector3(x, y, z));
        }

        public static Transform _AddPosXY(this Transform t, float x, float y)
        {
            return t._AddPos(new Vector3(x, y, 0f));
        }

        public static Transform _AddPosX(this Transform t, float x)
        {
            return t._AddPos(new Vector3(x, 0f, 0f));
        }

        public static Transform _AddPosY(this Transform t, float y)
        {
            return t._AddPos(new Vector3(0f, y, 0f));
        }

        public static Transform _AddPosZ(this Transform t, float z)
        {
            return t._AddPos(new Vector3(0f, 0f, z));
        }

        #endregion ADD TO POSITION

        #region RESET POSITION

        public static Transform _ResetAll(this Transform t)
        {
            t._ResetLocalPos();
            t._ResetEulerAngles();
            t._ResetScale();
            return t;
        }

        public static Transform _ResetLocalPos(this Transform t)
        {
            t.localPosition = Vector3.zero;
            return t;
        }

        public static Transform _ResetLocalPosX(this Transform t)
        {
            return t._SetLocalPosX(0f);
        }

        public static Transform _ResetLocalPosY(this Transform t)
        {
            return t._SetLocalPosY(0f);
        }

        public static Transform _ResetLocalPosXY(this Transform t)
        {
            return t._SetLocalPosXY(0f, 0f);
        }

        public static Transform _ResetLocalPosZ(this Transform t)
        {
            return t._SetLocalPosZ(0f);
        }

        public static Transform _ResetPos(this Transform t)
        {
            return t._SetPos(0f);
        }

        public static Transform _ResetPosX(this Transform t)
        {
            return t._SetPosX(0f);
        }

        public static Transform _ResetPosY(this Transform t)
        {
            return t._SetPosY(0f);
        }

        public static Transform _ResetPosXY(this Transform t)
        {
            return t._SetPosXY(0f, 0f);
        }

        public static Transform _ResetPosZ(this Transform t)
        {
            return t._SetPosZ(0f);
        }

        #endregion RESET POSITION

        #endregion

        #region EULER ANGLES

        #region SET EULER ANGLES

        public static Transform _SetLocalEulerAngles(this Transform t, Vector3 v3)
        {
            t.localEulerAngles = v3;
            return t;
        }

        public static Transform _SetLocalEulerAngles(this Transform t, float x, float y, float z)
        {
            return t._SetLocalEulerAngles(new Vector3(x, y, z));
        }

        public static Transform _SetLocalEulerAngles(this Transform t, float xyz)
        {
            t.localEulerAngles = new Vector3(xyz, xyz, xyz);
            return t;
        }

        public static Transform _SetLocalEulerAnglesXY(this Transform t, float x, float y)
        {
            return t._SetLocalEulerAngles(new Vector3(x, y, t.localEulerAngles.z));
        }

        public static Transform _SetLocalEulerAnglesX(this Transform t, float x)
        {
            var localEulerAngles = t.localEulerAngles;
            return t._SetLocalEulerAngles(new Vector3(x, localEulerAngles.y, localEulerAngles.z));
        }

        public static Transform _SetLocalEulerAnglesY(this Transform t, float y)
        {
            var localEulerAngles = t.localEulerAngles;
            return t._SetLocalEulerAngles(new Vector3(localEulerAngles.x, y, localEulerAngles.z));
        }

        public static Transform _SetLocalEulerAnglesZ(this Transform t, float z)
        {
            var localEulerAngles = t.localEulerAngles;
            return t._SetLocalEulerAngles(new Vector3(localEulerAngles.x, localEulerAngles.y, z));
        }

        public static Transform _SetEulerAngles(this Transform t, Vector3 v3)
        {
            t.eulerAngles = v3;
            return t;
        }

        public static Transform _SetEulerAngles(this Transform t, float x, float y, float z)
        {
            return t._SetEulerAngles(new Vector3(x, y, z));
        }

        public static Transform _SetEulerAngles(this Transform t, float xyz)
        {
            return t._SetEulerAngles(new Vector3(xyz, xyz, xyz));
        }

        public static Transform _SetEulerAnglesXY(this Transform t, float x, float y)
        {
            return t._SetEulerAngles(new Vector3(x, y, t.eulerAngles.z));
        }

        public static Transform _SetEulerAnglesX(this Transform t, float x)
        {
            var eulerAngles = t.eulerAngles;
            return t._SetEulerAngles(new Vector3(x, eulerAngles.y, eulerAngles.z));
        }

        public static Transform _SetEulerAnglesY(this Transform t, float y)
        {
            var eulerAngles = t.eulerAngles;
            return t._SetEulerAngles(new Vector3(eulerAngles.x, y, eulerAngles.z));
        }

        public static Transform _SetEulerAnglesZ(this Transform t, float z)
        {
            var eulerAngles = t.eulerAngles;
            return t._SetEulerAngles(new Vector3(eulerAngles.x, eulerAngles.y, z));
        }

        #endregion SET EULER ANGLES

        #region ADD TO EULER ANGLES

        public static Transform _AddLocalEulerAngles(this Transform t, Vector3 v3)
        {
            t.localEulerAngles += v3;
            return t;
        }

        public static Transform _AddLocalEulerAngles(this Transform t, float x, float y, float z)
        {
            return t._AddLocalEulerAngles(new Vector3(x, y, z));
        }

        public static Transform _AddLocalEulerAnglesXY(this Transform t, float x, float y)
        {
            return t._AddLocalEulerAngles(new Vector3(x, y, 0f));
        }

        public static Transform _AddLocalEulerAnglesX(this Transform t, float x)
        {
            return t._AddLocalEulerAngles(new Vector3(x, 0f, 0f));
        }

        public static Transform _AddLocalEulerAnglesY(this Transform t, float y)
        {
            return t._AddLocalEulerAngles(new Vector3(0f, y, 0f));
        }

        public static Transform _AddLocalEulerAnglesZ(this Transform t, float z)
        {
            return t._AddLocalEulerAngles(new Vector3(0f, 0f, z));
        }

        public static Transform _AddEulerAngles(this Transform t, Vector3 v3)
        {
            t.eulerAngles += v3;
            return t;
        }

        public static Transform _AddEulerAngles(this Transform t, float x, float y, float z)
        {
            return t._AddEulerAngles(new Vector3(x, y, z));
        }

        public static Transform _AddEulerAnglesXY(this Transform t, float x, float y)
        {
            return t._AddEulerAngles(new Vector3(x, y, 0f));
        }

        public static Transform _AddEulerAnglesX(this Transform t, float x)
        {
            return t._AddEulerAngles(new Vector3(x, 0f, 0f));
        }

        public static Transform _AddEulerAnglesY(this Transform t, float y)
        {
            return t._AddEulerAngles(new Vector3(0f, y, 0f));
        }

        public static Transform _AddEulerAnglesZ(this Transform t, float z)
        {
            return t._AddEulerAngles(new Vector3(0f, 0f, z));
        }

        #endregion ADD TO EULER ANGLES

        #region RESET EULER ANGLES

        public static Transform _ResetLocalEulerAngles(this Transform t)
        {
            t.localEulerAngles = Vector3.zero;
            return t;
        }

        public static Transform _ResetLocalEulerAnglesX(this Transform t)
        {
            return t._SetLocalEulerAnglesX(0f);
        }

        public static Transform _ResetLocalEulerAnglesY(this Transform t)
        {
            return t._SetLocalEulerAnglesY(0f);
        }

        public static Transform _ResetLocalEulerAnglesXY(this Transform t)
        {
            return t._SetLocalEulerAnglesXY(0f, 0f);
        }

        public static Transform _ResetLocalEulerAnglesZ(this Transform t)
        {
            return t._SetLocalEulerAnglesZ(0f);
        }

        public static Transform _ResetEulerAngles(this Transform t)
        {
            return t._SetEulerAngles(0f);
        }

        public static Transform _ResetEulerAnglesX(this Transform t)
        {
            return t._SetEulerAnglesX(0f);
        }

        public static Transform _ResetEulerAnglesY(this Transform t)
        {
            return t._SetEulerAnglesY(0f);
        }

        public static Transform _ResetEulerAnglesXY(this Transform t)
        {
            return t._SetEulerAnglesXY(0f, 0f);
        }

        public static Transform _ResetEulerAnglesZ(this Transform t)
        {
            return t._SetEulerAnglesZ(0f);
        }

        #endregion RESET EULER ANGLES

        #endregion

        #region SCALE

        #region SET SCALE

        public static Transform _SetScale(this Transform t, Vector3 v3)
        {
            t.localScale = v3;
            return t;
        }

        public static Transform _SetScale(this Transform t, float x, float y, float z)
        {
            return t._SetScale(new Vector3(x, y, z));
        }

        public static Transform _SetScale(this Transform t, float xyz)
        {
            t.localScale = new Vector3(xyz, xyz, xyz);
            return t;
        }

        public static Transform _SetScaleXY(this Transform t, float x, float y)
        {
            return t._SetScale(new Vector3(x, y, t.localScale.z));
        }

        public static Transform _SetScaleX(this Transform t, float x)
        {
            var localScale = t.localScale;
            return t._SetScale(new Vector3(x, localScale.y, localScale.z));
        }

        public static Transform _SetScaleY(this Transform t, float y)
        {
            var localScale = t.localScale;
            return t._SetScale(new Vector3(localScale.x, y, localScale.z));
        }

        public static Transform _SetScaleZ(this Transform t, float z)
        {
            var localScale = t.localScale;
            return t._SetScale(new Vector3(localScale.x, localScale.y, z));
        }

        #endregion SET SCALE

        #region ADD TO SCALE

        public static Transform _AddScale(this Transform t, Vector3 v3)
        {
            t.localScale += v3;
            return t;
        }

        public static Transform _AddScale(this Transform t, float x, float y, float z)
        {
            return t._AddScale(new Vector3(x, y, z));
        }

        public static Transform _AddScaleXY(this Transform t, float x, float y)
        {
            return t._AddScale(new Vector3(x, y, 0f));
        }

        public static Transform _AddScaleX(this Transform t, float x)
        {
            return t._AddScale(new Vector3(x, 0f, 0f));
        }

        public static Transform _AddScaleY(this Transform t, float y)
        {
            return t._AddScale(new Vector3(0f, y, 0f));
        }

        public static Transform _AddScaleZ(this Transform t, float z)
        {
            return t._AddScale(new Vector3(0f, 0f, z));
        }

        #endregion ADD TO SCALE

        #region RESET SCALE

        public static Transform _ResetScale(this Transform t)
        {
            t.localScale = Vector3.one;
            return t;
        }

        public static Transform _ResetScaleX(this Transform t)
        {
            return t._SetScaleX(1f);
        }

        public static Transform _ResetScaleY(this Transform t)
        {
            return t._SetScaleY(1f);
        }

        public static Transform _ResetScaleXY(this Transform t)
        {
            return t._SetScaleXY(1f, 1f);
        }

        public static Transform _ResetScaleZ(this Transform t)
        {
            return t._SetScaleZ(1f);
        }

        #endregion RESET SCALE

        #endregion
    }
}