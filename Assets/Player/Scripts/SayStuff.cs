using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayStuff : MonoBehaviour {

    public AudioClip victorySaying;
    public AudioClip shrinkSaying;
    private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sayVictory() {
        source.clip = victorySaying;
        source.Play();
    }

    public void sayShrinkSaying() {
        source.clip = shrinkSaying;
        source.Play();
    }
}
