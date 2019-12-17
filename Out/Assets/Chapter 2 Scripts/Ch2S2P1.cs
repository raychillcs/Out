using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch2S2P1 : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // if the screen has the finger moving
            if (touch.phase == TouchPhase.Moved)
            {
                SceneManager.LoadScene("ch2-s2-p2");
            }
        }
    }
}
