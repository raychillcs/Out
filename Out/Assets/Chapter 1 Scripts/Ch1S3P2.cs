using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ch1S3P2 : MonoBehaviour
{
    public Button button;

    void Awake()
    {
        button = gameObject.GetComponent<Button>(); //you get access to the button component here
        button.onClick.AddListener(() => NextScene()); //you assign a method to the button OnClick event here
    }

    void NextScene()
    {
        Invoke("DelayScene", 3);
    }

    void DelayScene()
    {
        SceneManager.LoadScene("ch1-s3-p3");
    }
}
