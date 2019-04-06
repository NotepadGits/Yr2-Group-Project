using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausedMenu;


    public int timer;
    public Text countdownText;

    void Start()
    {
        StartCoroutine("LoseTime");
    }


    void Update()
    {
        countdownText.text = ("" + timer);

        if(timer <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "0";
            Time.timeScale = 0f;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pausedMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PauseGame()
    {
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    public void ExitToMainMenu(string main)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(main);
    }

    public void ExitToWindow()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    IEnumerator LoseTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);

            timer--;
        }
    }
}