using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;


public class ChangeBrowForm : MonoBehaviour
{
    [SerializeField]
    CubismParameter ParamBrowLForm, ParamBrowRForm;

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ParamBrowLForm.Value = -1f;
            ParamBrowRForm.Value = -1f;
        }
        else
        {
            ParamBrowLForm.Value = 0f;
            ParamBrowRForm.Value = 0f;
        }
    }
}
