using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteElementState : MonoBehaviour
{

    public Sprite water;
    public Sprite earth;
    public Sprite wind;
    public Sprite fire;
    public Sprite holy;
    public Sprite Void;

    private GameObject player;

    private int state;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        state = player.GetComponent<Attack>().State;

        switch (state)
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
                GetComponent<SpriteRenderer>().sprite = wind;
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
}
