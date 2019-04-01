﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //references to other unity components
    public Rigidbody rb;


    //editable values
    public float Force = 1000;


    //uneditable values
    bool buttonUp = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //fixedUpdate for phyisics realted updates
    {
        //rb.AddForce vec3  (0,0,0 * Time.deltaTime)

        if (Input.GetKeyDown("w") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(0, 0,Force * Time.deltaTime);
            Debug.Log("W");
            GetComponent<Attack>().State = 0;
            GetComponent<Attack>().MovementDirection = 1;
        }
        else if (Input.GetKeyDown("a") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0);
            Debug.Log("a");
            GetComponent<Attack>().State = 0;
            GetComponent<Attack>().MovementDirection = 2;

        }
        else if (Input.GetKeyDown("s") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime);
            Debug.Log("s");
            GetComponent<Attack>().State = 0;
            GetComponent<Attack>().MovementDirection = 3;

        }
        else if (Input.GetKeyDown("d") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0);
            Debug.Log("d");
            GetComponent<Attack>().State = 0;
            GetComponent<Attack>().MovementDirection = 4;

        }


        //Debug.Log(buttonUp);
        //if (Input.GetButtonUp("w")) buttonUp = true;
    }
}
