using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type : MonoBehaviour
{

    public int State;
    // Start is called before the first frame update
    void Start()
    {
        switch (State)
        {
            case 0:
                GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0.5f, 0.5f);
                break;
            case 1:
                GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                break;
            case 4:
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case 5:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 6:
                GetComponent<Renderer>().material.color = Color.magenta;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
