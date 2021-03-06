﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmFollow : MonoBehaviour {

    public int playerNumber;
    //[SerializeField] private string joyY;
    private Vector3 armVector;
    private Vector3 gunAimerPos;
    private Vector3 mousePosition;
    private float angle;

   

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


      
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 direction = new Vector3(Input.GetAxis("Joy X " + playerNumber), Input.GetAxis("Joy Y " + playerNumber), 0); 
        float angle = Mathf.Atan2(direction.y, direction.x)*180/Mathf.PI;
        float parentRotation = transform.parent.localScale.x > 0 ? 0 : 1;
        transform.rotation = Quaternion.Euler(0, 0, angle + 180*parentRotation);
        
        

    }

    public void setPlayerNumber(int playNum) {
        playerNumber = playNum;
    }
}
