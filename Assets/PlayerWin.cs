using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.CompareTag("Player")) {
            print("Congrats! Player " + collision.collider.transform.parent.GetComponent<ShootBullets>().playerNumber + " wins");
        }
    }
}
