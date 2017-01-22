using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    private bool isPause = false;
    public GameObject menu;


	// Use this for initialization
	void Start () {
        menu.SetActive(false);
     
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pause")) {
            if (!isPause) {
                Time.timeScale = 0f;
                isPause = true;               
                menu.SetActive(isPause);
                print("paused");
                
            } else {
                Time.timeScale = 1f;
                isPause = false;
                menu.SetActive(isPause);
               
            }
        }
	}
}
