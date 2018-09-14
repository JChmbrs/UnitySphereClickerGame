using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class TransitionScript : MonoBehaviour {

    public TextMeshProUGUI transitionText;
    public TextMeshProUGUI yesText;
    public TextMeshProUGUI quitText;
    public TextMeshProUGUI pointsScored;

    // Use this for initialization
    void Start () {

        Debug.Log("currentLevel = " + PlayerPrefs.GetInt("currentLevel"));

        if (PlayerPrefs.GetInt("currentLevel") == 1)
        {
            StartCoroutine("beatLvl1Coroutine");
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 2)
        {
            StartCoroutine("beatLvl2Coroutine");
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 3)
        {
            StartCoroutine("beatLvl3Coroutine");
            return;
        }


    }

    IEnumerator beatLvl1Coroutine()
    {
        transitionText.text = "Congratulations! You made it to the next level by scoring 40 or more points!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Are you ready for the next level?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points";
        yesText.text = "PLAY NEXT LEVEL";
        quitText.text = "QUIT";
    }

    IEnumerator beatLvl2Coroutine()
    {
        transitionText.text = "Congratulations! You made it to the next level by scoring 95 or more points!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Are you ready for the next level?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points";
        yesText.text = "PLAY NEXT LEVEL";
        quitText.text = "QUIT";
    }

    IEnumerator beatLvl3Coroutine()
    {
        transitionText.text = "Congratulations! You made it to the next level by scoring 140 or more points!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Are you ready for the next level?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points";
        yesText.text = "PLAY NEXT LEVEL";
        quitText.text = "QUIT";
    }


    // Update is called once per frame
    void Update () {
		
	}
}
