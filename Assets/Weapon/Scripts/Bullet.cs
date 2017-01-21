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

    public void setStartPosition(Vector3 position, Vector2 direction, GameObject playerThatShotThis) {
        transform.position = position;
        movementVector = direction;
        movementVector.Normalize();
        movementVector *= movementSpeed;
        GetComponent<Rigidbody2D>().velocity = movementVector;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        print(collision.collider.tag);
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
                    playerThatShotThis.GetComponent<PlayerSizeChanger>().hitPlayerWithEnlargeWave(0.25f);
                    return;
                }
            }
            collision.collider.GetComponent<PlayerSizeChanger>().hitPlayerWithShrinkWave(0.25f);
        }

    }
}
