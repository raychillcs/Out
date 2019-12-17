using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ch1S4P3 : MonoBehaviour
{
	void Start()
	{
		Invoke("DelayScene", 3);
	}

	void DelayScene()
	{
		SceneManager.LoadScene("ch1-s5-p1");
	}
}
