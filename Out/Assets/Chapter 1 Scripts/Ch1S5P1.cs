using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch1S5P1 : MonoBehaviour
{
    private float holdTime = 0.8f; //or whatever
    private float acumTime = 0;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            acumTime += Input.GetTouch(0).deltaTime;

            if (acumTime >= holdTime)
            {
                //Long tap
                SceneManager.LoadScene("ch1-s5-p2");
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                acumTime = 0;
            }
        }
    }
}
