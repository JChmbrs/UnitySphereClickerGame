﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Level4 : MonoBehaviour
{

    public GameObject RightHighPointSphere;
    public GameObject RightMiddlePointSphere;
    public GameObject RightLowPointSphere;
    public GameObject LeftHighPointSphere;
    public GameObject LeftMiddlePointSphere;
    public GameObject LeftLowPointSphere;
    public GameObject TopHighPointSphere;
    public GameObject TopMiddlePointSphere;
    public GameObject TopLowPointSphere;
    public GameObject BottomHighPointSphere;
    public GameObject BottomMiddlePointSphere;
    public GameObject BottomLowPointSphere;
    float rightleftYBounds;
    float topbottomXBounds;
    float[] boundsArray;
    GameObject sphereHolder;
    int leftrightMax = 6;
    public TextMeshProUGUI timeLeftText;
    public static int timeLeftSecs = 30;
    private bool timeLeftBool = false;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI introText;
    private TextMeshProUGUI pointsTextHolder;
    public static int mainScriptCurrentLevel = 0;
    ClickAndDestroy scriptInstance = null;


    //TransitionScript move over variables
    protected int ptsNeededLevel1 = 60;
    protected int ptsNeededLevel2 = 120;
    protected int ptsNeededLevel3 = 180;
    protected int ptsNeededLevel4 = 240;
    private ClickAndDestroy pointsObject;
    public static int pointsAfter = 0;
    public static int ptsMultiple = 1;
    public static int[] ptsArray;
    public static int basePts = 40;
    public static int transitionCurrentLevel = 1;
    public static int currentLevelIndex = 0;
    public static int lvlBasePts = 40;
    public static int currentLevel = 1;




    // Use this for initialization
    void Start()
    {

        StartCoroutine("countDown");
    }

    // Update is called once per frame
    void Update()
    {


    }

    void rightBoundInst()
    {

        if (Random.value <= 0.08)
        {
            GameObject holdSphere = Instantiate(RightHighPointSphere, new Vector3(10f, Random.Range(-5.5f, 3f), 10.15f), Quaternion.identity); // Right Bounds

            return;
        }

        if (Random.value <= 0.2)
        {
            Instantiate(RightMiddlePointSphere, new Vector3(10f, Random.Range(-5.5f, 3f), 10.15f), Quaternion.identity); // Right Bounds
            return;
        }

        else
        {
            Instantiate(RightLowPointSphere, new Vector3(10f, Random.Range(-5.5f, 3f), 10.15f), Quaternion.identity); // Right Bounds
            return;
        }


    }

    void leftBoundInst()
    {

        if (Random.value <= 0.08)
        {
            GameObject holdSphere = Instantiate(LeftHighPointSphere, new Vector3(-10f, Random.Range(-5.5f, 4f), 10.15f), Quaternion.identity); // Right Bounds

            return;
        }

        if (Random.value <= 0.2)
        {
            Instantiate(LeftMiddlePointSphere, new Vector3(-10f, Random.Range(-5.5f, 2.2f), 10.15f), Quaternion.identity); // Right Bounds
            return;
        }

        else
        {
            Instantiate(LeftLowPointSphere, new Vector3(-10f, Random.Range(-5.5f, 2.2f), 10.15f), Quaternion.identity); // Right Bounds
            return;
        }

    }

    void topBoundInst()
    {
        if (Random.value <= 0.08)
        {
            GameObject holdSphere = Instantiate(TopHighPointSphere, new Vector3(Random.Range(-7.5f, 7.5f), 5.5f, 10.15f), Quaternion.identity); // Right Bounds

            return;
        }

        if (Random.value <= 0.2)
        {
            Instantiate(TopMiddlePointSphere, new Vector3(Random.Range(-7.5f, 7.5f), 5.5f, 10.15f), Quaternion.identity); // Right Bounds
            return;
        }

        else
        {
            Instantiate(TopLowPointSphere, new Vector3(Random.Range(-7.5f, 7.5f), 5.5f, 10.15f), Quaternion.identity); // Right Bounds
            return;
        }

    }

    void bottomBoundInst()
    {
        if (Random.value <= 0.08)
        {
            GameObject holdSphere = Instantiate(TopHighPointSphere, new Vector3(Random.Range(-7.5f, 7.5f), -7f, 10.15f), Quaternion.identity); // Right Bounds

            return;
        }

        if (Random.value <= 0.2)
        {
            Instantiate(TopMiddlePointSphere, new Vector3(Random.Range(-7.5f, 7.5f), -7f, 10.15f), Quaternion.identity); // Right Bounds
            return;
        }

        else
        {
            Instantiate(TopLowPointSphere, new Vector3(Random.Range(-7.5f, 7.5f), -7f, 10.15f), Quaternion.identity); // Right Bounds
            return;
        }
    }


    public int timeLeft()
    {
        timeLeftText.text = "Time Left: " + timeLeftSecs;
        timeLeftSecs -= 1;
        return timeLeftSecs;
    }

    IEnumerator mainCoroutine()
    {
        while (timeLeftSecs >= 0)
        {
            timeLeftSecs = timeLeft();
            yield return new WaitForSeconds(1f);

            rightBoundInst();
            leftBoundInst();
            topBoundInst();
            bottomBoundInst();
        }

        pointsAfter = ClickAndDestroy.points;
        int[] ptsArray = new int[4];
        Debug.Log("pointsAfter = " + pointsAfter);

        //making the ptsArray
        //for (int i = 0; i < ptsArray.Length; i++)
        //{
        //ptsArray[i] = basePts;
        //ptsMultiple += 1;
        //basePts = ptsMultiple * basePts;
        //}

        ptsArray = new int[] { 40, 95, 140, 170 };

        if (pointsAfter <= ptsArray[PlayerPrefs.GetInt("ptsArrayIndex")])
        {

            SceneManager.LoadScene(6);

        }

        if (pointsAfter >= ptsArray[PlayerPrefs.GetInt("ptsArrayIndex")])
        {
            SceneManager.LoadScene(7);
        }

    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(1f);
        introText.text = "3";
        yield return new WaitForSeconds(1f);
        introText.text = "2";
        yield return new WaitForSeconds(1f);
        introText.text = "1";
        yield return new WaitForSeconds(1f);
        introText.text = "GO!";
        yield return new WaitForSeconds(1f);
        introText.text = "";
        levelText.text = "Level 4";

        //calling pointsText from ClickAndDestroy
        GameObject tempObj = GameObject.Find("GameObject");
        scriptInstance = tempObj.GetComponent<ClickAndDestroy>();
        scriptInstance.pointsText.text = "Points: ";

        StartCoroutine("mainCoroutine");
    }

}
