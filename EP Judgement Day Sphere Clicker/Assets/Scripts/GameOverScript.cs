using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour {

    public TextMeshProUGUI transitionText;
    public TextMeshProUGUI yesText;
    public TextMeshProUGUI quitText;
    public TextMeshProUGUI pointsScored;

    // Use this for initialization
    void Start () {

        if (PlayerPrefs.GetInt("currentLevel") == 1)
        {
            StartCoroutine("lostLvl1Coroutine");
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 2)
        {
            StartCoroutine("lostLvl2Coroutine");
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 3)
        {
            StartCoroutine("lostLvl3Coroutine");
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 4)
        {
            StartCoroutine("lostLvl4Coroutine");
            return;
        }

    }

    IEnumerator lostLvl1Coroutine()
    {
        transitionText.text = "Oh no! You needed 40 points to make it to the next level!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Do you want to continue?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points (40 points needed for level 2)";
        yesText.text = "CONTINUE";
        quitText.text = "QUIT";
    }

    IEnumerator lostLvl2Coroutine()
    {
        transitionText.text = "Oh no! You needed 95 points to make it to the next level!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Do you want to continue?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points (95 points needed for level 3)";
        yesText.text = "CONTINUE";
        quitText.text = "QUIT";
    }

    IEnumerator lostLvl3Coroutine()
    {
        transitionText.text = "Oh no! You needed 140 points to make it to the next level!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Do you want to continue?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points (140 points needed for level 4)";
        yesText.text = "CONTINUE";
        quitText.text = "QUIT";
    }

    IEnumerator lostLvl4Coroutine()
    {
        transitionText.text = "Oh no! You needed 170 points to make it to the next level!";
        yield return new WaitForSeconds(4f);
        transitionText.text = "Do you want to continue?";
        yield return new WaitForSeconds(2f);
        transitionText.text = "";
        pointsScored.text = "You Scored: " + ClickAndDestroy.points + " points (170 points needed to beat the game)";
        yesText.text = "CONTINUE";
        quitText.text = "QUIT";
    }



    // Update is called once per frame
    void Update () {
		
	}
}
