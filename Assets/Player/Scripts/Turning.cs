using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour {
    private float randCheck;
    private SpriteRenderer sprite;
    private bool isWait = false;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isWait) {
            randCheck = Random.Range(0.0f, 1.0f);
            if (randCheck > 0.5f) {
                sprite.flipX = true;
            } else {
                sprite.flipX = false;
            }


            StartCoroutine(wait());
        }
        

	}
    IEnumerator wait(){
    isWait = true;
    yield return new WaitForSeconds(2);
    isWait = false;
    }
}
