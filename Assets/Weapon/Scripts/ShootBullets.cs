using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {

    public string name;
    public GameObject bullet;
    public Transform startPosition;
    public int playerNumber;
    public float waitTime;
    private bool coolingDown = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire " + playerNumber) && !coolingDown) {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 0;            
            Vector3 joystickPosition = new Vector3(Input.GetAxis("Joy X " + playerNumber), Input.GetAxis("Joy Y " + playerNumber), 0);
            Vector3 direction = joystickPosition;
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.GetComponent<Bullet>().setStartPosition(startPosition.position, direction, gameObject);
            StartCoroutine(cooldown());
        }
	}

    public void setPlayerNumber(int playNum) {
        playerNumber = playNum;
    }

    IEnumerator cooldown() {
        coolingDown = true;
        yield return new WaitForSeconds(waitTime);
        coolingDown = false;
    }
}
