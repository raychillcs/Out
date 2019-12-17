using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChSelect1 : MonoBehaviour
{
    public Button ch1Button;
    public Button ch2Button;
    public Button ch3Button;

    void Awake()
    {
        ch1Button.onClick.AddListener(() => buttonCallBack(ch1Button)); //you assign a method to the button OnClick event here
        ch2Button.onClick.AddListener(() => buttonCallBack(ch2Button));
        ch3Button.onClick.AddListener(() => buttonCallBack(ch3Button));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == ch1Button)
        {
            SceneManager.LoadScene("ch1-title");
        }

        if (buttonPressed == ch2Button)
        {
            SceneManager.LoadScene("ch2-title");
        }

        if (buttonPressed == ch3Button)
        {
            SceneManager.LoadScene("ch3-title");
        }
    }
}
