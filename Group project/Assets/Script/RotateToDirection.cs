using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToDirection : MonoBehaviour
{

    Vector3 movementDirection;
    Quaternion direction;
    Vector3 origin;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        origin = gameObject.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = gameObject.transform.position - origin;

        angle = Mathf.Atan2(movementDirection.z, -movementDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        direction = transform.rotation;

    }
}
