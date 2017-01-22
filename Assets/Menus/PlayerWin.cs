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
            Application.LoadLevel("TitleScreen");
        }

	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Player")) {
            winNumber = collision.collider.transform.parent.GetComponent<ShootBullets>().playerNumber;
            print(winNumber);
            if(winNumber == 1) {
                player = "DeBroccoli WINS!";
            } else if(winNumber == 2) {
                player = "Dr. Plonck WINS!";
            } else if(winNumber == 3) {
                player = "Shrodanger WINS!";
            } else {
                player = "Nobody Wins...";
            }

            Time.timeScale = 0f;

            win.SetActive(true);
            win.GetComponentInChildren<Text>().text = player;
            
        }
    }
}
