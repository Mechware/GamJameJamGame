using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCoolDown : MonoBehaviour {

    private bool waiting;
    public float timeToWait;

	// Use this for initialization
	void Start () {
        waiting = false;

	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (!waiting) {
            if (collision.collider.CompareTag("Bullet")) {
                GetComponent<Collider2D>().isTrigger = true;
                StartCoroutine(waitTime(timeToWait));
            }   
        }

    }

    IEnumerator waitTime(float length) {
        waiting = true;
        yield return new WaitForSeconds(length);
        GetComponent<Collider2D>().isTrigger = false;
        waiting = false;
    }
}
