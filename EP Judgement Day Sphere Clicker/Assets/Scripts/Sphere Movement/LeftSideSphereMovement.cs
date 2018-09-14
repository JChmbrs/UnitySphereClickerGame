using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSideSphereMovement : MonoBehaviour {

    float speed = 8f;
    int leftrightMax = 6;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Destroy(gameObject, 4f);

    }
}
