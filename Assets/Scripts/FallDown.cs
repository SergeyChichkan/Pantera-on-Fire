using UnityEngine;
using System.Collections;

public class FallDown : MonoBehaviour {

    private float fallSpeed = 5f;

    float playerYposition;
    bool isScoreAdded;

    GameManagerScript gameManager;

    void Start() {

        playerYposition = GameObject.Find("Player").transform.position.y;

        isScoreAdded = false;

        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerScript>();

    }

	void Update () {

        if (Player.lose == false) {
            if (transform.position.y <= playerYposition)
            {
                if (!isScoreAdded)
                {
                    AddScore();
                    isScoreAdded = true;
                }
            }
        }

        if (transform.position.y < -6f)
            Destroy(gameObject);

        transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);

	}

    void AddScore()
    {
        gameManager.GmAddScore();
    }
}
