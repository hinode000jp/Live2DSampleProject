using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;

public class ParameterLateUpdate : MonoBehaviour
{
    private CubismModel _model;
    private float _t;

    void Start()
    {
        _model = this.FindCubismModel();
    }

    void LateUpdate()
    {
        _t += (Time.deltaTime * 4f);
        var value = Mathf.Sin(_t) * 10f;

        var parameter = _model.Parameters[14];
        parameter.Value = value;
    }
}
