using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch2Title : MonoBehaviour
{
    void Start()
    {
        Invoke("DelayScene", 3);
    }

    void DelayScene()
    {
        SceneManager.LoadScene("ch2-s1-p1");
    }
}
