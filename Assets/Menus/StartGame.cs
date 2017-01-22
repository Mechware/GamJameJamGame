using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public bool canPlay;
	// Use this for initialization
	void Start () {
        canPlay = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Start") && canPlay ) {
            Application.LoadLevel("Level1");
        }
	}

    public void setPlay() {
        canPlay = true;
    }
}
