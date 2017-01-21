﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 0;
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0;
            Vector3 direction = transform.position - mouseWorldPosition;
            GameObject bulletObj = Instantiate(bullet);
            Vector3 startPos = transform.position;
            startPos.x += 3;
            bulletObj.GetComponent<Bullet>().setStartPosition(startPos, direction);

        }
	}
}
