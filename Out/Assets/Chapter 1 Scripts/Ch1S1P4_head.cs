using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1S1P4_head : MonoBehaviour
{
    private Vector3 originPosition;
    public float shake_decay = 0.002f;
    public float shake_intensity = 4f;

    private float temp_shake_intensity = 0;

    void Update()
    {
        if (temp_shake_intensity > 0)
        {
            transform.position = originPosition + Random.insideUnitSphere * temp_shake_intensity;
            temp_shake_intensity -= shake_decay;
        }

        Shake();
    }

    void Shake()
    {
        originPosition = transform.position;
        temp_shake_intensity = shake_intensity;
    }
}
