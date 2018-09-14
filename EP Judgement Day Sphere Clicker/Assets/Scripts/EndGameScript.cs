using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class EndGameScript : MonoBehaviour {

    public TextMeshProUGUI endGameText;
    public TextMeshProUGUI backToMainMenu;

    // Use this for initialization
    void Start () {
        StartCoroutine("playText");
	}

    IEnumerator playText()
    {
        yield return new WaitForSeconds(13f);
        endGameText.text = "Programming: Jake Chambers \n Music: Jake Chambers \n Sound Clips: electric playground / judgement day";
        backToMainMenu.text = "to main menu";
    }


	
}
