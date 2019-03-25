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
    void FixedUpdate() //fixedUpdate for phyisics realted updates
    {
        //rb.AddForce vec3  (0,0,0 * Time.deltaTime)

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0,Force * Time.deltaTime);
            Debug.Log("W");

        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime);
            Debug.Log("a");

        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime);
            Debug.Log("s");

        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime);
            Debug.Log("d");

        }


        //Debug.Log(buttonUp);
        //if (Input.GetButtonUp("w")) buttonUp = true;
    }
}
