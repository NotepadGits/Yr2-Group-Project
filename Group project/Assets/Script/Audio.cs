﻿using UnityEngine.Audio;
using System;
using UnityEngine;


public class Audio : MonoBehaviour
{

    public Sound[] sounds;

    public static Audio instance;

    // Start is called before the first frame update
    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }


        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

   void Start()
    {
        Play("Bgm");
    }


    // Update is called once per frame
    public void Play (string name) 
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found! Spelling???");
            return;
        }
        s.source.Play();
    }
}
