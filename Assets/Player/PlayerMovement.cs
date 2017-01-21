using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public float moveSpeed = 1f;
    public float jumpSpeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xMovement = moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime;
        float yMovement = jumpSpeed*Input.GetAxis("Jump")*Time.deltaTime;
        Vector3 translationDistance = new Vector3(xMovement, yMovement);
        transform.Translate(translationDistance);
    }
}
