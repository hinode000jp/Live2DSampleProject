using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;

[RequireComponent(typeof(AudioSource))]
public class SimpleLipSyncer : MonoBehaviour
{
    AudioSource audioSource = null;

    [SerializeField]
    CubismParameter MouthOpenParameter = null;

    float velosity = 0.0f;
    float currentVolume = 0.0f;

    [SerializeField]
    float Power = 20f;

    [SerializeField, Range(0f, 1f)]
    float Threshold = 0.1f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = Microphone.Start(null, true, 1, 44100);

        while (Microphone.GetPosition(null) <= 0) { }
        audioSource.Play();
        audioSource.loop = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float targetVolume = GetAveragedVolume() * Power;
        targetVolume = targetVolume < Threshold ? 0 : targetVolume;
        currentVolume = Mathf.SmoothDamp(currentVolume, targetVolume, ref velosity, 0.05f);

        if (MouthOpenParameter == null)
        {
            Debug.LogError("MouthOpenParameterが設定されていません");
            return;
        }
        MouthOpenParameter.Value = Mathf.Clamp01(currentVolume);
    }

    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        audioSource.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 255.0f;
    }
}
