# UniExt
Unity Extensions

```cs
public void SetTransform()
{
    transform
        ._SetPosXY(x,y)         // transform.positon = new Vector3(x,y,transform.positon.z);
        ._ResetEulerAngles()    // transform.eulerAngles = Vector3.zero;
        ._SetScaleX(1.5f);      // transform.localScale =  new Vector3(1.5f,
                                //                                transform.localScale.y,
                                //                                transform.localScale.z);
}
```


```cs
//GameObject
public static GameObject _go(this Transform tr);

//Transform
public static Transform _Active(this Transform tr);
public static Transform _Passive(this Transform tr);
public static T _Get<T>(this Transform tr) where T : Component;
public static T _Add<T>(this Transform tr) where T : Component;
public static T _GetOrAdd<T>(this Transform tr) where T : Component;
public static bool _Has<T>(this Transform tr) where T : Component;

//Transform Set Position
public static Transform _SetLocalPos(this Transform t, Vector3 v3);
public static Transform _SetLocalPos(this Transform t, float x, float y, float z);
public static Transform _SetLocalPos(this Transform t, float xyz);
public static Transform _SetLocalPosXY(this Transform t, float x, float y);
public static Transform _SetLocalPosX(this Transform t, float x);
public static Transform _SetLocalPosY(this Transform t, float y);
public static Transform _SetLocalPosZ(this Transform t, float z);
public static Transform _SetPos(this Transform t, Vector3 v3);
public static Transform _SetPos(this Transform t, float x, float y, float z);
public static Transform _SetPos(this Transform t, float xyz);
public static Transform _SetPosXY(this Transform t, float x, float y);
public static Transform _SetPosX(this Transform t, float x);
public static Transform _SetPosY(this Transform t, float Y);
public static Transform _SetPosZ(this Transform t, float Z);

//Transform Add to Position
public static Transform _AddLocalPos(this Transform t, Vector3 v3);
public static Transform _AddLocalPos(this Transform t, float x, float y, float z);
public static Transform _AddLocalPosXY(this Transform t, float x, float y);
public static Transform _AddLocalPosX(this Transform t, float x);
public static Transform _AddLocalPosY(this Transform t, float y);
public static Transform _AddLocalPosZ(this Transform t, float z);
public static Transform _AddPos(this Transform t, Vector3 v3);
public static Transform _AddPos(this Transform t, float x, float y, float z);
public static Transform _AddPosXY(this Transform t, float x, float y);
public static Transform _AddPosX(this Transform t, float x);
public static Transform _AddPosY(this Transform t, float y);
public static Transform _AddPosZ(this Transform t, float z);

//Transform Reset Position
public static Transform _ResetAll(this Transform t);
public static Transform _ResetLocalPos(this Transform t);
public static Transform _ResetLocalPosX(this Transform t);
public static Transform _ResetLocalPosY(this Transform t);
public static Transform _ResetLocalPosXY(this Transform t);
public static Transform _ResetLocalPosZ(this Transform t);
public static Transform _ResetPos(this Transform t);
public static Transform _ResetPosX(this Transform t);
public static Transform _ResetPosY(this Transform t);
public static Transform _ResetPosXY(this Transform t);
public static Transform _ResetPosZ(this Transform t);

     
//Transform Set Euler Angles
public static Transform _SetLocalEulerAngles(this Transform t, Vector3 v3);
public static Transform _SetLocalEulerAngles(this Transform t, float x, float y, float z);
public static Transform _SetLocalEulerAngles(this Transform t, float xyz);
public static Transform _SetLocalEulerAnglesXY(this Transform t, float x, float y);
public static Transform _SetLocalEulerAnglesX(this Transform t, float x);
public static Transform _SetLocalEulerAnglesY(this Transform t, float y);
public static Transform _SetLocalEulerAnglesZ(this Transform t, float z);
public static Transform _SetEulerAngles(this Transform t, Vector3 v3);
public static Transform _SetEulerAngles(this Transform t, float x, float y, float z);
public static Transform _SetEulerAngles(this Transform t, float xyz);
public static Transform _SetEulerAnglesXY(this Transform t, float x, float y);
public static Transform _SetEulerAnglesX(this Transform t, float x);
public static Transform _SetEulerAnglesY(this Transform t, float y);
public static Transform _SetEulerAnglesZ(this Transform t, float z);


//Transform Add to Euler Angles
public static Transform _AddLocalEulerAngles(this Transform t, Vector3 v3);
public static Transform _AddLocalEulerAngles(this Transform t, float x, float y, float z);
public static Transform _AddLocalEulerAnglesXY(this Transform t, float x, float y);
public static Transform _AddLocalEulerAnglesX(this Transform t, float x);
public static Transform _AddLocalEulerAnglesY(this Transform t, float y);
public static Transform _AddLocalEulerAnglesZ(this Transform t, float z);
public static Transform _AddEulerAngles(this Transform t, Vector3 v3);
public static Transform _AddEulerAngles(this Transform t, float x, float y, float z);
public static Transform _AddEulerAnglesXY(this Transform t, float x, float y);
public static Transform _AddEulerAnglesX(this Transform t, float x);
public static Transform _AddEulerAnglesY(this Transform t, float y);
public static Transform _AddEulerAnglesZ(this Transform t, float z);

//Transform Reset Euler Angles
public static Transform _ResetLocalEulerAngles(this Transform t);
public static Transform _ResetLocalEulerAnglesX(this Transform t);
public static Transform _ResetLocalEulerAnglesY(this Transform t);
public static Transform _ResetLocalEulerAnglesXY(this Transform t);
public static Transform _ResetLocalEulerAnglesZ(this Transform t);
public static Transform _ResetEulerAngles(this Transform t);
public static Transform _ResetEulerAnglesX(this Transform t);
public static Transform _ResetEulerAnglesY(this Transform t);
public static Transform _ResetEulerAnglesXY(this Transform t);
public static Transform _ResetEulerAnglesZ(this Transform t);

//Transform Set Scale
public static Transform _SetScale(this Transform t, Vector3 v3);
public static Transform _SetScale(this Transform t, float x, float y, float z);
public static Transform _SetScale(this Transform t, float xyz);
public static Transform _SetScaleXY(this Transform t, float x, float y);
public static Transform _SetScaleX(this Transform t, float x);
public static Transform _SetScaleY(this Transform t, float y);
public static Transform _SetScaleZ(this Transform t, float z);

//Transform Add To Scale
public static Transform _AddScale(this Transform t, Vector3 v3);
public static Transform _AddScale(this Transform t, float x, float y, float z);
public static Transform _AddScaleXY(this Transform t, float x, float y);
public static Transform _AddScaleX(this Transform t, float x);
public static Transform _AddScaleY(this Transform t, float y);
public static Transform _AddScaleZ(this Transform t, float z);

//Transform Reset Scale
public static Transform _ResetScale(this Transform t);
public static Transform _ResetScaleX(this Transform t);
public static Transform _ResetScaleY(this Transform t);
public static Transform _ResetScaleXY(this Transform t);
public static Transform _ResetScaleZ(this Transform t);

```
