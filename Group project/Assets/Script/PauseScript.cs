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

    void Update()
    {
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
}