using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public GameObject restart;
    public static bool lose = false;
    //public Texture2D Background;


    void Awake() {

        lose = false;

    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag == "Fireball")
            lose = true;
        restart.SetActive(true);

    }

        public void Back_Button()
    {
        SceneManager.LoadScene("MainMenu_1");
    }

        void Update() { 
        
            if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
             SceneManager.LoadScene("MainMenu_1");
        }

}
