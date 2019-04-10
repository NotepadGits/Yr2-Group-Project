using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackflavourSpriteChoise : MonoBehaviour
{

    public Sprite water;
    public Sprite earth;
    public Sprite air;
    public Sprite fire;
    public Sprite holy;
    public Sprite Void;
    // Start is called before the first frame update
    void Start()
    {
        switch (gameObject.GetComponentInParent<Type>().State)
        {
            case 0:
                GetComponent<SpriteRenderer>().sprite = null;
                break;
            case 1:
                GetComponent<SpriteRenderer>().sprite = water;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = earth;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = air;
                break;
            case 4:
                GetComponent<SpriteRenderer>().sprite = fire;
                break;
            case 5:
                GetComponent<SpriteRenderer>().sprite = holy;
                break;
            case 6:
                GetComponent<SpriteRenderer>().sprite = Void;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
