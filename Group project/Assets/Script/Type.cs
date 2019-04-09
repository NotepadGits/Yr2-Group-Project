using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type : MonoBehaviour
{

    public int State;

    public ParticleSystem fire_Effect;
    public ParticleSystem water_Effect;
    public ParticleSystem void_Effect;
    public ParticleSystem wind_Effect;
    public ParticleSystem earth_Effect;

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
        if(State == 4)
        {
        	var fire_efx = Instantiate(fire_Effect, gameObject.transform.position, Quaternion.identity);
        	fire_efx.transform.parent = gameObject.transform;
        }
        if(State == 1)
        {
        	var water_efx = Instantiate(water_Effect, gameObject.transform.position, Quaternion.identity);
        	water_efx.transform.parent = gameObject.transform;
        }
        if(State == 6)
        {
        	var void_efx = Instantiate(void_Effect, gameObject.transform.position, Quaternion.identity);
        	void_efx.transform.parent = gameObject.transform;
        }
        if(State == 3)
        {
        	var wind_efx = Instantiate(wind_Effect, gameObject.transform.position, Quaternion.identity);
        	wind_efx.transform.parent = gameObject.transform;
        }
        if(State == 2)
        {
        	var earth_vfx = Instantiate(earth_Effect, gameObject.transform.position, Quaternion.identity);
        	earth_vfx.transform.parent = gameObject.transform;
        }
    }
}
