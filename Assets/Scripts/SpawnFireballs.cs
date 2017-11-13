using System.Collections;
using UnityEngine;

public class SpawnFireballs : MonoBehaviour {

    public GameObject fireball;
    public float spawnTime;
    public GameManagerScript GameManagerScript;


	void Start () {

        spawnTime = 0.6f;
        StartCoroutine(Spawn());

	}

    IEnumerator Spawn () {

        while (!Player.lose) { 
        
            Instantiate (fireball, new Vector2 (Random.Range (-2.6f, 2.6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }

    }

    void Update() {

        switch (GameManagerScript.myScoreGUI.text) { 
        
            case "50":
                spawnTime = 0.5f;
                break;

            case "100":
                spawnTime = 0.4f;
                break;

            case "200":
                spawnTime = 0.3f;
                break;

        }

    }

}
