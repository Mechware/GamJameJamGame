using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCoolDown : MonoBehaviour {

    private bool isWait;
    public int timeToWait;

	// Use this for initialization
	void Start () {
        isWait = false;

	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (!isWait) {
            GetComponent<Collider2D>().isTrigger = false;
            if (collision.collider.CompareTag("Bullet")) {
                GetComponent<Collider2D>().isTrigger = true;
                StartCoroutine(waitTime(timeToWait));
            }   
        }

    }

    IEnumerator waitTime(int length) {
        isWait = true;
        yield return new WaitForSeconds(length);
        isWait = false;
    }
}
