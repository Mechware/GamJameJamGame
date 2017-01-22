using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float movementSpeed = 5f;
    private Vector2 movementVector;
    private GameObject playerThatShotThis;

    public string[] destoryTags;

	// Use this for initialization
	void Start () {
        
	}

    void Update() {
        
    }

    public void setStartPosition(Vector3 position, Vector2 direction, GameObject playerThatShotThis) {
        if (direction.magnitude == 0 || Time.timeScale == 0)
            Destroy(gameObject);
        transform.position = position;
        movementVector = direction;
        movementVector.Normalize();
        movementVector *= movementSpeed;
        GetComponent<Rigidbody2D>().velocity = movementVector;
        this.playerThatShotThis = playerThatShotThis;
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        
        foreach(string tagThatDestorysThis in destoryTags) {
            if(collision.collider.CompareTag(tagThatDestorysThis)) {
                Destroy(this.gameObject);
                return;
            }
        }
        if(collision.collider.CompareTag("Player")) {
            Collider2D[] thisPlayersColliders = playerThatShotThis.GetComponentsInChildren<Collider2D>();
            foreach (Collider2D thisPlayersCollider in thisPlayersColliders) {
                if(collision.collider == thisPlayersCollider) {
                    playerThatShotThis.GetComponent<PlayerSizeChanger>().hitPlayerWithShrinkWave(0.25f);
                    playerThatShotThis.GetComponent<SayStuff>().sayShrinkSaying();
                    Destroy(this.gameObject);
                    return;
                }
            }
            collision.collider.transform.parent.GetComponent<PlayerSizeChanger>().hitPlayerWithEnlargeWave(0.25f);
            Destroy(this.gameObject);
        }

    }
}
