using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;public class ChangeSmileForm : MonoBehaviour
{

    [SerializeField]
    CubismParameter ParamEyeLOpen, ParamEyeROpen;
    [SerializeField]
    CubismParameter ParamEyeLSmile, ParamEyeRSmile;

    CubismEyeBlinkController eyeController;

    void Start()
    {        eyeController = GetComponent<CubismEyeBlinkController>();    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))        {            eyeController.enabled = false;            ParamEyeLOpen.Value = 0;            ParamEyeROpen.Value = 0;            ParamEyeLSmile.Value = 1;            ParamEyeRSmile.Value = 1;        }        else        {            eyeController.enabled = true;            ParamEyeLOpen.Value = 1;            ParamEyeROpen.Value = 1;            ParamEyeLSmile.Value = 0;            ParamEyeRSmile.Value = 0;        }
    }
}
