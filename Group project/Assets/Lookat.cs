using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{

    public GameObject self;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        self.transform.Rotate(-65f, -180f, 0f);
    }
}
