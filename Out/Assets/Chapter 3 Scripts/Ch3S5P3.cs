﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch3S5P3 : MonoBehaviour
{
    void Start()
    {
        Invoke("DelayScene", 3);
    }

    void DelayScene()
    {
        SceneManager.LoadScene("ch3-s6");
    }
}
