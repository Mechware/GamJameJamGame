using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SwitchScenes : MonoBehaviour {

    public float waitTime = 10f;

	// Use this for initialization
	void Start () {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
        StartCoroutine(switchScenes());
	}
	
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButtonDown("Jump 1") ||
           CrossPlatformInputManager.GetButtonDown("Jump 2") ||
           CrossPlatformInputManager.GetButtonDown("Jump 3")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }
	}

    IEnumerator switchScenes() {
        yield return new WaitForSeconds(waitTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }
}
