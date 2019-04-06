using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{

    Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {

        targetPos = new Vector3(transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
        transform.LookAt(targetPos);
 
    }
}
