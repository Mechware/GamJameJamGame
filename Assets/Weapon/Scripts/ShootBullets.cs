using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {

    public GameObject bullet;
    public Transform startPosition;
    public int playerNumber;
    //[SerializeField] private string joyX;
    //[SerializeField] private string joyY;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire " + playerNumber)) {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 0;            
            Vector3 joystickPosition = new Vector3(Input.GetAxis("Joy X " + playerNumber), Input.GetAxis("Joy Y " + playerNumber), 0);
            Vector3 direction = joystickPosition;
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.GetComponent<Bullet>().setStartPosition(startPosition.position, direction, gameObject);
        }
	}
}
