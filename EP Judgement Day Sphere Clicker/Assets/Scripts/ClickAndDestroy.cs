using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickAndDestroy : MonoBehaviour {

    int HighPtValue = 10;
    int MiddlePtValue = 5;
    int LowPtValue = 1;
    public static int points = 0;
    public TextMeshProUGUI pointsText;

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "HighPoint")
                {
                    points += HighPtValue;
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.tag == "MiddlePoint")
                {
                    points += MiddlePtValue;
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.tag == "LowPoint")
                {
                    points += LowPtValue;
                    Destroy(hit.collider.gameObject);
                }
            }

            pointsText.text = "Points: " + points;

        }

    }
}
