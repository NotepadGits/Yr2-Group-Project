using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int MovementDirection = 0;
    public int State = 0;

    public GameObject attackOrb; //The prefab for our attack hitbox
    public Transform Player;        //Where the player is

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1)) State = 1;
        if (Input.GetKeyDown(KeyCode.Keypad2)) State = 2;
        if (Input.GetKeyDown(KeyCode.Keypad3)) State = 3;
        if (Input.GetKeyDown(KeyCode.Keypad4)) State = 4;
        if (Input.GetKeyDown(KeyCode.Keypad5)) State = 5;
        if (Input.GetKeyDown(KeyCode.Keypad6)) State = 6;


        switch(State)
        {
            case 0:
                GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0.5f, 0.5f);
                
                break;
            case 1:
                GetComponent<Renderer>().material.color = Color.cyan;
                FindObjectOfType<Audio>().Play("WaterAttack");
                
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.green;
                FindObjectOfType<Audio>().Play("EarthAttack");
                
                break;
            case 3:
                GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                FindObjectOfType<Audio>().Play("AirAttack");
                
                break;
            case 4:
                GetComponent<Renderer>().material.color = Color.red;
                FindObjectOfType<Audio>().Play("FireAttack");
                break;
            case 5:
                GetComponent<Renderer>().material.color = Color.yellow;
                FindObjectOfType<Audio>().Play("ElectricAttack");
                break;
            case 6:
                GetComponent<Renderer>().material.color = Color.magenta;
                FindObjectOfType<Audio>().Play("VoidAttack");
                break;

        }

       
    }
}
