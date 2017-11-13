using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {

	public void Game_Start () {
        SceneManager.LoadScene("Game_1");
	}

    public void Contacts_Scene() {
        SceneManager.LoadScene("Contacts_1");
    }

    public void Quit_Scene() {
        Application.Quit ();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
            Application.Quit();
    }
}
