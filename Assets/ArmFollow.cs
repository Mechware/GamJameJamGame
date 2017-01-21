using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmFollow : MonoBehaviour {

  
    private Vector3 armVector;
    private Vector3 gunAimerPos;
    private Vector3 mousePosition;
    private float angle;

   

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        /*
        Vector3 zeroAngle;
        zeroAngle.x = 1; zeroAngle.y = 0; zeroAngle.z = 0;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        float mouseAngle = Vector3.Angle(zeroAngle, mousePosition);
        print("" + mouseAngle);
        if (transform.position.y > mousePosition.y)
        {
            transform.rotation = Quaternion.Euler(0, 0, -mouseAngle);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, mouseAngle);
        }*/

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x)*180/Mathf.PI;
        transform.rotation = Quaternion.Euler(0, 0, angle);


    }
}
