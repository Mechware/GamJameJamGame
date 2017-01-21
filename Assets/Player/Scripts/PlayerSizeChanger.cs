using UnityEngine;

public class PlayerSizeChanger : MonoBehaviour {

    private Vector3 startSize;

	// Use this for initialization
	void Start () {
        startSize = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void hitPlayerWithShrinkWave(float shrinkPercent) {
        bool flipped = transform.localScale.x < 0;
        Vector3 shrinkAmount = startSize*shrinkPercent;
        shrinkAmount.x = flipped ? -1*shrinkAmount.x : shrinkAmount.x;
        transform.localScale -= shrinkAmount;
    }

    public void hitPlayerWithEnlargeWave(float growPercent) {
        bool flipped = transform.localScale.x < 0;
        Vector3 growAmount = startSize*growPercent;
        growAmount.x = flipped ? -1*growAmount.x : growAmount.x;
        transform.localScale += growAmount;
    }
}
