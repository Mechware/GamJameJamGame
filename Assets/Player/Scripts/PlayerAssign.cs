using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAssign : MonoBehaviour {

    //need to deactivate all players
    //need to activate the selected players
    //need to setPlayerNumber to corresponding controller


        //everything MUST be in order Shrod -> Plonck -> deBrock ... aka player 3 -> player 2 -> player 1 or it wont work
    public GameObject[] characters = new GameObject[3];
    public ArmFollow[] arms = new ArmFollow[3];
    public ShootBullets[] bullets = new ShootBullets[3];
    public UnityStandardAssets._2D.Platformer2DUserControl[] moves = new UnityStandardAssets._2D.Platformer2DUserControl[3];


    private int p1 = 1;
    private int p2 = 2;
    private int p3 = 3;

	// Use this for initialization
	void Start () {
        
            for(int i = 0 ; i < characters.Length ; i++) {
            characters[i].SetActive(false);


            // Camera has issues if characters are deleted from the scene...
           /* if(PlayerSelect.shrod == false) {
                Destroy(characters[0]);
            }
            if(PlayerSelect.plonck == false) {
                Destroy(characters[1]);
            }
            if(PlayerSelect.deBrock == false) {
                Destroy(characters[2]);
            } */
        }
        
	}
	
	// Update is called once per frame
	void Update () {

        //assign player1
		if(PlayerSelect.player1 == "Shrodanger") {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p1);
            bullets[0].setPlayerNumber(p1);
            moves[0].setPlayerNumber(p1);
        }
        if (PlayerSelect.player1 == "Plonck") {
            characters[1].SetActive(true);
            arms[1].setPlayerNumber(p1);
            bullets[1].setPlayerNumber(p1);
            moves[1].setPlayerNumber(p1);
        }
        if (PlayerSelect.player1 == "DeBroccoli") {
            characters[2].SetActive(true);
            arms[2].setPlayerNumber(p1);
            bullets[2].setPlayerNumber(p1);
            moves[2].setPlayerNumber(p1);
        }
        //assign player2
        if (PlayerSelect.player2 == "Shrodanger") {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p2);
            bullets[0].setPlayerNumber(p2);
            moves[0].setPlayerNumber(p2);
        }
        if (PlayerSelect.player2 == "Plonck") {
            characters[1].SetActive(true);
            arms[1].setPlayerNumber(p2);
            bullets[1].setPlayerNumber(p2);
            moves[1].setPlayerNumber(p2);
        }
        if (PlayerSelect.player2 == "DeBroccoli") {
            characters[2].SetActive(true);
            arms[2].setPlayerNumber(p2);
            bullets[2].setPlayerNumber(p2);
            moves[2].setPlayerNumber(p2);
        }
        //assign player3
        if (PlayerSelect.player3 == "Shrodanger") {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p3);
            bullets[0].setPlayerNumber(p3);
            moves[0].setPlayerNumber(p3);
        }
        if (PlayerSelect.player3 == "Plonck") {
            characters[1].SetActive(true);
            arms[1].setPlayerNumber(p3);
            bullets[1].setPlayerNumber(p3);
            moves[1].setPlayerNumber(p3);
        }
        if (PlayerSelect.player3 == "DeBroccoli") {
            characters[2].SetActive(true);
            arms[2].setPlayerNumber(p3);
            bullets[2].setPlayerNumber(p3);
            moves[2].setPlayerNumber(p3);
        }

        if(!characters[0].activeSelf && !characters[1].activeSelf && !characters[2].activeSelf) {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(1);
            bullets[0].setPlayerNumber(1);
            moves[0].setPlayerNumber(1);
        }
    }
}
