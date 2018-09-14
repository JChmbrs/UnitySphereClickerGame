using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour {

    public void levelCheck()
    {
        if (PlayerPrefs.GetInt("currentLevel") == 1)
        {
            ClickAndDestroy.points = 0;
            PlayerPrefs.SetInt("currentLevel", 2);
            PlayerPrefs.SetInt("ptsArrayIndex", 1);
            SceneManager.LoadScene(2);
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 2)
        {
            ClickAndDestroy.points = 0;
            PlayerPrefs.SetInt("currentLevel", 3);
            PlayerPrefs.SetInt("ptsArrayIndex", 2);
            SceneManager.LoadScene(3);
            return;

        }

        if (PlayerPrefs.GetInt("currentLevel") == 3)
        {
            ClickAndDestroy.points = 0;
            PlayerPrefs.SetInt("currentLevel", 4);
            PlayerPrefs.SetInt("ptsArrayIndex", 3);
            SceneManager.LoadScene(4);
            return;
        }

    }

    public void continueLevel()
    {
        if (PlayerPrefs.GetInt("currentLevel") == 1)
        {
            ClickAndDestroy.points = 0;
            CannonScript.timeLeftSecs = 30;
            SceneManager.LoadScene(1);
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 2)
        {
            ClickAndDestroy.points = 0;
            Level2.timeLeftSecs = 30;
            SceneManager.LoadScene(2);
            return;

        }

        if (PlayerPrefs.GetInt("currentLevel") == 3)
        {
            ClickAndDestroy.points = 0;
            Level3.timeLeftSecs = 30;
            SceneManager.LoadScene(3);
            return;
        }

        if (PlayerPrefs.GetInt("currentLevel") == 4)
        {
            ClickAndDestroy.points = 0;
            Level4.timeLeftSecs = 30;
            SceneManager.LoadScene(4);
            return;
        }
    }

    public void toMainMenu()
    {
        ClickAndDestroy.points = 0;
        if (PlayerPrefs.GetInt("currentLevel") == 1)
        {
            CannonScript.timeLeftSecs = 30;
            SceneManager.LoadScene(0);
        }

        if (PlayerPrefs.GetInt("currentLevel") == 2)
        {
            CannonScript.timeLeftSecs = 30;
            Level2.timeLeftSecs = 30;
            SceneManager.LoadScene(0);
        }

        if (PlayerPrefs.GetInt("currentLevel") == 3)
        {
            CannonScript.timeLeftSecs = 30;
            Level2.timeLeftSecs = 30;
            Level3.timeLeftSecs = 30;
            SceneManager.LoadScene(0);
        }

        if (PlayerPrefs.GetInt("currentLevel") == 4)
        {
            CannonScript.timeLeftSecs = 30;
            Level2.timeLeftSecs = 30;
            Level3.timeLeftSecs = 30;
            Level4.timeLeftSecs = 30;
            SceneManager.LoadScene(0);
        }

    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void toMainMenuFromOptions()
    {
        SceneManager.LoadScene(0);
    }

    public void toOptions()
    {
        SceneManager.LoadScene(8);
    }


}
