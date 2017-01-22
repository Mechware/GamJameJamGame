using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {
    private float randCheck;
    public SpriteRenderer sprite;
    private bool isWait = false;
	// Use this for initialization
	void Start () {
		
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
                       
            wait();
        }
	}

    IEnumerator wait(){
    isWait = true;
    yield return new WaitForSeconds(1);
    isWait = false;
    }
}
