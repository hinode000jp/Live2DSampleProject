﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;
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
    {

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
    }
}