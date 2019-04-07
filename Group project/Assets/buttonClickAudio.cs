using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClickAudio : MonoBehaviour
{

    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1)) sound.Play();
        if (Input.GetKeyDown(KeyCode.Keypad2)) sound.Play();
        if (Input.GetKeyDown(KeyCode.Keypad3)) sound.Play();
        if (Input.GetKeyDown(KeyCode.Keypad4)) sound.Play();
        if (Input.GetKeyDown(KeyCode.Keypad5)) sound.Play();
        if (Input.GetKeyDown(KeyCode.Keypad6)) sound.Play();
    }
}
