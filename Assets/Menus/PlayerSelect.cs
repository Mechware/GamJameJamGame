using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour {

    public static bool deBrock, plonck, shrod;
    public bool p1, p2, p3;
    public StartGame playButton;
    public GameObject play;
    public GameObject deBroccoli, drPlonck, shrodanger;
    public static string player1, player2, player3;

	// Use this for initialization
	void Start () {
        deBrock = false;
        plonck = false;
        shrod = false;
        p1 = false;
        p2 = false;
        p3 = false;
        play.SetActive(false);
        deBroccoli.SetActive(false);
        drPlonck.SetActive(false);
        shrodanger.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        //check how many players
		if( (p1 && p2) || (p1 && p3) || (p2 && p3) || (p1 && p2 && p3)) {
            play.SetActive(true);
            playButton.setPlay();
        }

        //can probably use loops and arrays to do this but im #helladumb -Dylan
        //assign player 1 character
        if(Input.GetButton("Square 1") && !p1 && !shrod) {
            p1 = true;
            shrod = true;
            player1 = "Shrodanger";
            shrodanger.SetActive(shrod);
        } 
        if(Input.GetButton("Triangle 1") && !p1 && !plonck) {
            p1 = true;
            plonck = true;
            player1 = "Plonck";
            drPlonck.SetActive(plonck);
        }
        if (Input.GetButton("Circle 1") && !p1 && !deBrock) {
            p1 = true;
            deBrock = true;
            player1 = "DeBroccoli";
            deBroccoli.SetActive(deBrock);
        }

        //assign player 2 character
        if (Input.GetButton("Square 2") && !p2 && !shrod) {
            p2 = true;
            shrod = true;
            player2 = "Shrodanger";
            shrodanger.SetActive(shrod);
        }
        if (Input.GetButton("Triangle 2") && !p2 && !plonck) {
            p2 = true;
            plonck = true;
            player2 = "Plonck";
            drPlonck.SetActive(plonck);
        }
        if (Input.GetButton("Circle 2") && !p2 && !deBrock) {
            p2 = true;
            deBrock = true;
            player2 = "DeBroccoli";
            deBroccoli.SetActive(deBrock);
        }

        //assign player 3 character
        if (Input.GetButton("Square 3") && !p3 && !shrod) {
            p3 = true;
            shrod = true;
            player3 = "Shrodanger";
            shrodanger.SetActive(shrod);
        }
        if (Input.GetButton("Triangle 3") && !p3 && !plonck) {
            p3 = true;
            plonck = true;
            player3 = "Plonck";
            drPlonck.SetActive(plonck);
        }
        if (Input.GetButton("Circle 3") && !p3 && !deBrock) {
            p3 = true;
            deBrock = true;
            player3 = "DeBroccoli";
            deBroccoli.SetActive(deBrock);
        }

    }
}
