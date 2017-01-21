using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float movementSpeed = 5f;
    private Vector2 movementVector;

	// Use this for initialization
	void Start () {
        
	}

    /*
    public void setStartPosition(Vector3 position, Vector2 direction) {
        transform.position = position;
        movementVector = -1*direction;
        movementVector.Normalize();
        movementVector *= movementSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 whereToMove = Time.deltaTime*movementVector;
        transform.Translate(whereToMove);
	}*/

    public void setStartPosition(Vector3 position, Vector2 direction) {
        transform.position = position;
        movementVector = direction;
        movementVector.Normalize();
        movementVector *= movementSpeed;
        GetComponent<Rigidbody2D>().velocity = movementVector;
    }
}
