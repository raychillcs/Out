using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch1S3P1 : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // if the screen has the finger moving
            if (touch.phase == TouchPhase.Moved)
            {
                SceneManager.LoadScene("ch1-s3-p2");
            }
        }
    }
}
