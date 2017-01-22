using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour {
    public float waitTime = 0.5f;
    public Transform logo;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(waitTime);
        logo.localScale *= 0.5f;
        yield return new WaitForSeconds(waitTime);
        logo.localScale *= 0.5f;
        yield return new WaitForSeconds(waitTime);
        logo.localScale *= 0.5f;
        yield return new WaitForSeconds(waitTime);
        logo.localScale *= 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScreen");
    }

    // Update is called once per frame
    void Update () {
        
        
	}


}
