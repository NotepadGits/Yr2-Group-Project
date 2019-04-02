using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //references to other unity components
    public Rigidbody rb;


    //editable values
    public float Force = 1000;
    public float Velocity; // velocity of the attackOrb

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
            GetComponent<Attack>().MovementDirection = 1;
        }
        else if (Input.GetKeyDown("a") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0);
            Debug.Log("a");
            GetComponent<Attack>().MovementDirection = 2;

        }
        else if (Input.GetKeyDown("s") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime);
            Debug.Log("s"); 
            GetComponent<Attack>().MovementDirection = 3;

        }
        else if (Input.GetKeyDown("d") && GetComponent<Attack>().State != 0)
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0);
            Debug.Log("d");
            GetComponent<Attack>().MovementDirection = 4;

        }



        if (GetComponent<Attack>().State != 0)
        {
            if (Input.GetKeyDown("w") || Input.GetKeyDown("d") || Input.GetKeyDown("s") || Input.GetKeyDown("a"))
            {
                GameObject attack = Instantiate(GetComponent<Attack>().attackOrb, GetComponent<Attack>().Player.position, GetComponent<Attack>().Player.rotation);
                if (GetComponent<Attack>().MovementDirection == 1) attack.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, Velocity);
                if (GetComponent<Attack>().MovementDirection == 2) attack.GetComponent<Rigidbody>().velocity = new Vector3(-Velocity, 0, 0);
                if (GetComponent<Attack>().MovementDirection == 3) attack.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -Velocity);
                if (GetComponent<Attack>().MovementDirection == 4) attack.GetComponent<Rigidbody>().velocity = new Vector3(Velocity, 0, 0);
                attack.GetComponent<Type>().State = GetComponent<Attack>().State;
                //  attack.GetComponent<EmptyScript>().emptyfunc();


                GetComponent<Attack>().State = 0;
            }
        }

        if(Input.GetKeyDown("d") || Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s"))
        {
            GetComponent<Attack>().State = 0;
        }
        //Debug.Log(buttonUp);
        //if (Input.GetButtonUp("w")) buttonUp = true;
    }
}
