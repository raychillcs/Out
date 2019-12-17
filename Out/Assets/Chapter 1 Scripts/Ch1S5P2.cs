using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch1S5P2 : MonoBehaviour
{
    void Start()
    {
        Invoke("DelayScene", 3);
    }

    void DelayScene()
    {
        SceneManager.LoadScene("chselect");
    }
}
