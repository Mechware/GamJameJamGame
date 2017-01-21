using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {

    public GameObject bullet;
    public Transform startPosition;
    [SerializeField] private string fire;
    [SerializeField] private string joyX;
    [SerializeField] private string joyY;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) || Input.GetButtonDown(fire)) {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 0;            
            Vector3 joystickPosition = new Vector3(Input.GetAxis(joyX), Input.GetAxis(joyY), 0);
            Vector3 direction = joystickPosition;
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.GetComponent<Bullet>().setStartPosition(startPosition.position, direction);

        }
	}
}
