using System.Collections;
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

        if (Input.GetKeyDown("w"))
        {
            rb.AddForce(0, 0,Force * Time.deltaTime);
            Debug.Log("W");

        }
        else if (Input.GetKeyDown("a"))
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0);
            Debug.Log("a");

        }
        else if (Input.GetKeyDown("s"))
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime);
            Debug.Log("s");

        }
        else if (Input.GetKeyDown("d"))
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0);
            Debug.Log("d");

        }


        //Debug.Log(buttonUp);
        //if (Input.GetButtonUp("w")) buttonUp = true;
    }
}
