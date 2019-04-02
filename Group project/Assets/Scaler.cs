using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    //public GameObject orb;
    public Transform orbTransform;
    public float scaleFactor;

    private float death = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        orbTransform.localScale = orbTransform.localScale + new Vector3(Time.deltaTime / scaleFactor, Time.deltaTime / scaleFactor, Time.deltaTime / scaleFactor);
        death = death + Time.deltaTime;
        if (death > 5)
        {
            Destroy(gameObject);
        }
    }
}
