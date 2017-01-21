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
      
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x)*180/Mathf.PI;
        transform.rotation = Quaternion.Euler(0, 0, angle);


    }
}
