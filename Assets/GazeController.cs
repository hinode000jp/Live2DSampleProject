using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;

public class GazeController : MonoBehaviour
{
    [SerializeField]
    Transform Anchor = null;

    Vector3 centerOnScreen;

    void Start()
    {
        centerOnScreen = Camera.main.WorldToScreenPoint(Anchor.position);
    }

    void LateUpdate()
    {
        var mousePos = Input.mousePosition - centerOnScreen;
        UpdateRotate(new Vector3(mousePos.x, mousePos.y, 0) * 0.2f);
    }
    Vector3 currentRotation = Vector3.zero;
    Vector3 eulerVelocity = Vector3.zero;

    [SerializeField]
    CubismParameter HeadAngleX = null, HeadAngleY = null, HeadAngleZ = null;
    [SerializeField]
    CubismParameter EyeBallX = null, EyeBallY = null;
    [SerializeField]
    float EaseTime = 0.2f;
    [SerializeField]
    float EyeBallXRate = 0.05f;
    [SerializeField]
    float EyeBallYRate = 0.02f;
    [SerializeField]
    bool ReversedGazing = false;

    void UpdateRotate(Vector3 targetEulerAngle)
    {
        currentRotation = Vector3.SmoothDamp(currentRotation, targetEulerAngle, ref eulerVelocity, EaseTime);

        SetParameter(HeadAngleX, currentRotation.x);
        SetParameter(HeadAngleY, currentRotation.y);
        SetParameter(HeadAngleZ, currentRotation.z);

        SetParameter(EyeBallX, currentRotation.x * EyeBallXRate * (ReversedGazing ? -1 : 1));
        SetParameter(EyeBallY, currentRotation.y * EyeBallYRate * (ReversedGazing ? -1 : 1));
    }

    void SetParameter(CubismParameter parameter, float value)
    {
        if (parameter != null)
        {
            parameter.Value = Mathf.Clamp(value, parameter.MinimumValue, parameter.MaximumValue);
        }
    }
}
