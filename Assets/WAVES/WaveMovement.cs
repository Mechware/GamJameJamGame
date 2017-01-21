using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMovement : MonoBehaviour {

    public float frequency, amplitude, phase;

	// Use this for initialization
	void Start () {
        StartCoroutine(moveInWave(frequency, phase, amplitude));
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    IEnumerator moveInWave(float frequency, float phase, float amplitude) {
        Vector3 position = new Vector3(0, 0, 0);
        while(true) {
            position.x += Time.deltaTime;
            position.y = amplitude * Mathf.Cos(frequency*position.x + phase);
            transform.localPosition = position;
            yield return null;
        }
        
    }
}
