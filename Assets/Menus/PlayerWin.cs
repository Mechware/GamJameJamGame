using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour {

    private int winNumber;
    private string player;
    public GameObject win; 

	// Use this for initialization
	void Start () {
        win.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("MainMenu")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("CreditsScene");
        }
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Player")) {
            winNumber = collision.collider.transform.parent.GetComponent<ShootBullets>().playerNumber;
            collision.collider.transform.parent.GetComponent<SayStuff>().sayVictory();
            player = collision.collider.transform.parent.GetComponent<ShootBullets>().name + " WINS!";
            Time.timeScale = 0f;

            win.SetActive(true);
            win.GetComponentInChildren<Text>().text = player;
            
        }
    }
}
