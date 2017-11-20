using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public GameObject restart;
    public static bool lose = false;
    private AudioSource ButtonClick;
    public AudioSource LoseSound;


    void Awake()
    {
        lose = false;
        ButtonClick = gameObject.GetComponent<AudioSource>();   
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag == "Fireball")
            lose = true;
        Time.timeScale = 0f;
        LoseSound.Play();
        restart.SetActive(true);

    }

        public void Back_Button()
    {
        ButtonClick.Play();
        SceneManager.LoadScene("MainMenu_1");
    }

       public void Restart_Button()
        {
            ButtonClick.Play ();
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("Game_1");
        }

        void Update() { 
        
            if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
             SceneManager.LoadScene("MainMenu_1");
        }

}
