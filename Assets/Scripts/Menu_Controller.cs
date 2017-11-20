using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {

    private AudioSource ButtonClick;

    void Awake() {
        ButtonClick = gameObject.GetComponent<AudioSource>();   
    }

	public void Game_Start () {
        ButtonClick.Play();
        SceneManager.LoadScene("Game_1");
	}

    public void Contacts_Scene() {
        ButtonClick.Play();
        SceneManager.LoadScene("Contacts_1");
    }

    public void Quit_Scene() {
        ButtonClick.Play();
        Application.Quit ();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
            Application.Quit();
    }
}
