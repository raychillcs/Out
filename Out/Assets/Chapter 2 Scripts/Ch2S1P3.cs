using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ch2S1P3 : MonoBehaviour
{
    public Button button;

    void Awake()
    {
        button = gameObject.GetComponent<Button>(); //you get access to the button component here
        button.onClick.AddListener(() => NextScene()); //you assign a method to the button OnClick event here
    }

    void NextScene()
    {
        SceneManager.LoadScene("ch2-s1-p4");
    }
}
