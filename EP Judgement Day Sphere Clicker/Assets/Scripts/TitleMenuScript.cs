using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenuScript : MonoBehaviour {

    public void PlayGame()
    {
        PlayerPrefs.SetInt("currentLevel", 1);
        PlayerPrefs.SetInt("ptsArrayIndex", 0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }


}
