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
	void Awake () {
        
        if(!PlayerSelect.shrod && !PlayerSelect.plonck && !PlayerSelect.deBrock) {
            DestroyImmediate(characters[1]);
            DestroyImmediate(characters[2]);
        } else {
            if (PlayerSelect.shrod == false) {
                DestroyImmediate(characters[0]);
            }
            if (PlayerSelect.plonck == false) {
                DestroyImmediate(characters[1]);
            }
            if (PlayerSelect.deBrock == false) {
                DestroyImmediate(characters[2]);
            }
        }
	}

    void Start() {
        bool player1Set = true, player2Set = true, player3Set = true;

        if (PlayerSelect.player1 == "Shrodanger") {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p1);
            bullets[0].setPlayerNumber(p1);
            moves[0].setPlayerNumber(p1);
        } else if (PlayerSelect.player1 == "Plonck") {
            characters[1].SetActive(true);
            arms[1].setPlayerNumber(p1);
            bullets[1].setPlayerNumber(p1);
            moves[1].setPlayerNumber(p1);
        } else if (PlayerSelect.player1 == "DeBroccoli") {
            characters[2].SetActive(true);
            arms[2].setPlayerNumber(p1);
            bullets[2].setPlayerNumber(p1);
            moves[2].setPlayerNumber(p1);
        } else
            player1Set = false;

        //assign player2
        if (PlayerSelect.player2 == "Shrodanger") {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p2);
            bullets[0].setPlayerNumber(p2);
            moves[0].setPlayerNumber(p2);
        } else if (PlayerSelect.player2 == "Plonck") {
            characters[1].SetActive(true);
            arms[1].setPlayerNumber(p2);
            bullets[1].setPlayerNumber(p2);
            moves[1].setPlayerNumber(p2);
        } else if (PlayerSelect.player2 == "DeBroccoli") {
            characters[2].SetActive(true);
            arms[2].setPlayerNumber(p2);
            bullets[2].setPlayerNumber(p2);
            moves[2].setPlayerNumber(p2);
        } else
            player2Set = false;

        //assign player3
        if (PlayerSelect.player3 == "Shrodanger") {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p3);
            bullets[0].setPlayerNumber(p3);
            moves[0].setPlayerNumber(p3);
        } else if (PlayerSelect.player3 == "Plonck") {
            characters[1].SetActive(true);
            arms[1].setPlayerNumber(p3);
            bullets[1].setPlayerNumber(p3);
            moves[1].setPlayerNumber(p3);
        } else if (PlayerSelect.player3 == "DeBroccoli") {
            characters[2].SetActive(true);
            arms[2].setPlayerNumber(p3);
            bullets[2].setPlayerNumber(p3);
            moves[2].setPlayerNumber(p3);
        } else
            player3Set = false;

        if (!player1Set && !player2Set && !player3Set) {
            characters[0].SetActive(true);
            arms[0].setPlayerNumber(p1);
            bullets[0].setPlayerNumber(p1);
            moves[0].setPlayerNumber(p1);
        }
    }
	
	// Update is called once per frame
	void Update () {

        //assign player1
		
    }
}
