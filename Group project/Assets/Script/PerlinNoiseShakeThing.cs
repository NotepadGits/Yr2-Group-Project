using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseShakeThing : MonoBehaviour
{
    [Range(0, 200)]
    public float frequency = 1f;
    public float magnitude = 1f;

    public float centreForce = 1f;

    public bool shake = true;

    private Vector3 centreLocalPos;

    float perlin(float x, float y)
    {
        return (Mathf.PerlinNoise(x, y) - 0.5f) * 2f;
    }

    private void Start()
    {
        centreLocalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (shake)
        {
            float noiseX = perlin(Time.time * frequency, 0) * magnitude;
            float noiseY = perlin(0, Time.time * frequency) * magnitude;
            float noiseZ = perlin(Time.time * frequency, Time.time) * magnitude;

            Vector3 translate = new Vector3(noiseX, noiseY, noiseZ);

            transform.localPosition += translate * Time.deltaTime;
        }

        transform.localPosition = Vector3.Lerp(transform.localPosition, centreLocalPos, Time.deltaTime * centreForce);

        //transform.Translate(translate);
    }
}
