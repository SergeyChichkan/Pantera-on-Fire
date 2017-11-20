using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contacts_Controller : MonoBehaviour {

    public GameObject Help;
    private AudioSource ButtonClick;

    void Awake()
    {
        ButtonClick = gameObject.GetComponent<AudioSource>();
    }

    public void Help_Button()
    {
        ButtonClick.Play();
        Help.SetActive(Help.active == false ? true : false);

        //Help.active = Help.active == false ? true : false;
    }

    public void Website_Button()
    {
        Application.OpenURL("https://fireshow-pantera.com/");
    }

    public void Kyivstar_Button()
    {
        TextEditor KyivPN = new TextEditor();
        KyivPN.text = "0977360228";
        KyivPN.SelectAll();
        KyivPN.Copy();
        TouchScreenKeyboard.Open("0977360228", TouchScreenKeyboardType.PhonePad, true, false, false);
    }

    public void Lifcell_Button()
    {
        TextEditor LifePN = new TextEditor();
        LifePN.text = "0937710826";
        LifePN.SelectAll();
        LifePN.Copy();
        TouchScreenKeyboard.Open("0937710826", TouchScreenKeyboardType.PhonePad, true, false, false);
    }

    public void Email_Button()
    {
        TextEditor EmailAddress = new TextEditor();
        EmailAddress.text = "pantera.ct@gmail.com";
        EmailAddress.SelectAll();
        EmailAddress.Copy();
        TouchScreenKeyboard.Open("pantera.ct@gmail.com", TouchScreenKeyboardType.EmailAddress, true, false, false);
    }

    public void Facebook_Button()
    {
        Application.OpenURL("https://www.facebook.com/fireshowpantera");
    }

    public void Instagram_Button()
    {
        Application.OpenURL("https://www.instagram.com/fireshow_pantera/");
    }

    public void Youtube_Button()
    {
        Application.OpenURL("https://www.youtube.com/c/PanteraCt");
    }

    public void VK_Button()
    {
        Application.OpenURL("https://vk.com/fireshow_pantera");
    }

    public void Back_Button()
    {
        ButtonClick.Play();
        SceneManager.LoadScene("MainMenu_1");
        ButtonClick.Play();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Home) || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Menu)) 
        {
            if (Help.active == true)
                Help.SetActive(false);
            else
                SceneManager.LoadScene("MainMenu_1");
        }
           // SceneManager.LoadScene("MainMenu_1");
    }
}
