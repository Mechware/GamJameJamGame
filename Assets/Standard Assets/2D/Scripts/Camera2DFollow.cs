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
    public string p1, p2, p3, p4;

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

    private List<GameObject> players;
    private float startZ;

    // Use this for initialization
    private void Start()
    {
        cam = GetComponent<Camera>();
        startZ = cam.transform.position.z;

        players = new List<GameObject>();
        GameObject player = GameObject.Find(p1);
        if(player != null)
            players.Add(GameObject.Find(p1));
        player = GameObject.Find(p2);
        if (player != null)
            players.Add(GameObject.Find(p2));
        player = GameObject.Find(p3);
        if (player != null)
            players.Add(GameObject.Find(p3));
        player = GameObject.Find(p4);
        if (player != null)
            players.Add(GameObject.Find(p4));
        
    }


    // Update is called once per frame
    private void Update()
    {

        Vector3 playerA = players[0].transform.position;
        Vector3 PlayerB = players[0].transform.position;
        Vector3 maxDistance = new Vector3(0, 0, 0);
        foreach(GameObject player in players) {
            foreach(GameObject player2 in players) {
                Vector3 difference = (player2.transform.position - player.transform.position);
                if (difference.magnitude > maxDistance.magnitude) {
                    playerA = player.transform.position;
                    PlayerB = player2.transform.position;
                    maxDistance = difference;
                }
            }
        }

        Vector3 inTheMiddle = (playerA + PlayerB)/2;
        inTheMiddle.z = -10;
        transform.position = inTheMiddle;
        print(maxDistance.magnitude);

        if(maxDistance.magnitude < minLength) {
            cam.orthographicSize = minZoom;
        } else if (maxDistance.magnitude > maxLength) {
            cam.orthographicSize = maxZoom;
        } else {
            cam.orthographicSize = ((maxDistance.magnitude-minLength)/(maxLength-minLength))*(maxZoom-minZoom)+minZoom;
        }

        return;
        
    }
}
