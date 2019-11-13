using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;public class ChangeSmileForm : MonoBehaviour
{

    [SerializeField]
    CubismParameter ParamEyeLOpen;
    [SerializeField]
    CubismParameter ParamEyeROpen;
    [SerializeField]
    CubismParameter ParamEyeLSmile;
    [SerializeField]
    CubismParameter ParamEyeRSmile;

    CubismEyeBlinkController eyeController;

    void Start()
    {        eyeController = GetComponent<CubismEyeBlinkController>();    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))        {            eyeController.enabled = false;            ParamEyeLOpen.Value = 0;            ParamEyeROpen.Value = 0;            Debug.Log("eye=" + ParamEyeLOpen.Value);            ParamEyeLSmile.Value = 1;            ParamEyeRSmile.Value = 1;        }        else        {            eyeController.enabled = true;            ParamEyeLOpen.Value = 1;            ParamEyeROpen.Value = 1;            ParamEyeLSmile.Value = 0;            ParamEyeRSmile.Value = 0;            Debug.Log("eye=" + ParamEyeLOpen.Value);        }
    }
}
