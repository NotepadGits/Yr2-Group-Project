using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void Start()
    {
        transform.position = target.position + offset;
    }

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}

