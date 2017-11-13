using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public int myScore;
    public Text myScoreGUI;

	void Start () {
        myScore = 0;

        myScoreGUI = GameObject.Find("Score").GetComponent<Text>();
	}

    public void GmAddScore() {
        this.myScore++;
        myScoreGUI.text = myScore.ToString();
    }



}
