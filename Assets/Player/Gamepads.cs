using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepads : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("player 1 press x");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump1")) {
            print("player 1 accepted");
        }
		
	}
}
