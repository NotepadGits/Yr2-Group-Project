using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorScript : MonoBehaviour
{
    public int State = 0;
    public GameObject enemy;

    void Start()
    {
        State = RandomNumberGenerator();
        ChooseEnemyColour();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /* Randomly generate a number between 1,6.
     * compare the randomly generated state to a condition in the switch statement.
     * run the switch statement when enemies are created to determine their colour.
     */

    public void ChooseEnemyColour()
    {
        switch (State)
        {
            case 0:
                GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.5f, 0.5f, 0.5f);
                break;
            case 1:
                GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
                break;
            case 2:
                GetComponent<Renderer>().sharedMaterial.color = Color.green;
                break;
            case 3:
                GetComponent<Renderer>().sharedMaterial.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                break;
            case 4:
                GetComponent<Renderer>().sharedMaterial.color = Color.red;
                break;
            case 5:
                GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
                break;
            case 6:
                GetComponent<Renderer>().sharedMaterial.color = Color.magenta;
                break;

        }
    }

    int RandomNumberGenerator()
    {
        int randomNum = Random.Range(0, 6);
        return randomNum;
    }
}
