using System;
using System.Collections.Generic;
using UnityEngine;

public class Camera2DFollow : MonoBehaviour
{
    //public Transform target;
    //public float damping = 1;
    //public float lookAheadFactor = 3;
    // public float lookAheadReturnSpeed = 0.5f;
    // public float lookAheadMoveThreshold = 0.1f;
    public GameObject[] players;

    // private float m_OffsetZ;
    // private Vector3 m_LastTargetPosition;
    // private Vector3 m_CurrentVelocity;
    //private Vector3 m_LookAheadPos;
    private Vector3 cameraPos;
    private Camera cam;
    private float maxLength = 75;
    private float minLength = 25;
    private float maxZoom = 43;
    private float minZoom = 15;

    private List<GameObject> _players;
    private float startZ;

    // Use this for initialization
    private void Start() {
        cam = GetComponent<Camera>();
        startZ = cam.transform.position.z;

        _players = new List<GameObject>();
        foreach (GameObject player in players) {
            if(player != null) {
                _players.Add(player);
            }      
        }
    }


    // Update is called once per frame
    private void Update()
    {
        if(_players.Count == 0) {
            return;
        }

        float playerAx = _players[0].transform.position.x;
        float playerBx = _players[0].transform.position.x;
        float playerCy = _players[0].transform.position.y;
        float playerDy = _players[0].transform.position.y;
        Vector3 maxDistance = new Vector3(0, 0, 0);
        foreach(GameObject player in _players) {
            foreach(GameObject player2 in _players) {
                Vector3 difference = (player2.transform.position - player.transform.position);
                if (difference.x > maxDistance.x) {
                    playerAx = player.transform.position.x;
                    playerBx = player2.transform.position.x;
                    maxDistance.x = difference.x;
                }
                if(difference.y > maxDistance.y) {
                    playerCy = player.transform.position.y;
                    playerDy = player2.transform.position.y;
                    maxDistance.y = difference.y;
                }
            }
        }

        Vector3 inTheMiddle = new Vector3((playerAx + playerBx)/2, (playerCy + playerDy)/2);
        inTheMiddle.z = startZ;
        transform.position = Vector3.Lerp(transform.position, inTheMiddle, Time.deltaTime);

        if(maxDistance.magnitude < minLength) {
            cam.orthographicSize = minZoom+5;
        } else if (maxDistance.magnitude > maxLength) {
            cam.orthographicSize = maxZoom+5;
        } else {
            cam.orthographicSize = ((maxDistance.magnitude-minLength)/(maxLength-minLength))*(maxZoom-minZoom)+minZoom+5;
        }
    }
}
