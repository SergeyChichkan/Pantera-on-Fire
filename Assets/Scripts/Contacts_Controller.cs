using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contacts_Controller : MonoBehaviour {

    public void Website_Button()
    {
        Application.OpenURL("https://fireshow-pantera.com/");
    }

    public void Back_Button()
    {
        SceneManager.LoadScene("MainMenu_1");
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

    void Update()
    {

        if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
            SceneManager.LoadScene("MainMenu_1");
    }
}
