using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;


public class ChangeBrowForm : MonoBehaviour
{
    [SerializeField]
    CubismParameter ParamBrowLForm = null;
    [SerializeField]
    CubismParameter ParamBrowRForm = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
