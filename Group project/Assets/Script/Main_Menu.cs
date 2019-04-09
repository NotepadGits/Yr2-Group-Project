using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class Main_Menu : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource highlightedAudio;

    public GameObject panalMain;
    public GameObject settingPanal;


    public void OnPointerEnter(PointerEventData ped)
    {
        highlightedAudio.Play();
    }

    public void PlayGame(string scenceName)
    {
        SceneManager.LoadScene(scenceName);
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void OpenPanal()
    {
        if(panalMain != null)
        {
            Animator animateMain = panalMain.GetComponent<Animator>();
            Animator animateSett = settingPanal.GetComponent<Animator>();

            if(animateMain != null)
            {
                bool isOpen = animateMain.GetBool("open");

                animateMain.SetBool("open", !isOpen);
            }
            if(animateSett != null)
            {
                bool openSettings = animateSett.GetBool("open");

                animateSett.SetBool("open", !openSettings);
            }
        }

    }
}
