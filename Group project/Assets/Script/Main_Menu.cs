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
}
