using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class gameUI : MonoBehaviour
{
    public int timer;
    public Text countdownText;

    public int startingHealth;
    int currenthealth;

    public Slider healthBar;

    public int startScore = 0;
    int currentScore;
    public Text scoreText;

    public Animator fadeIn;
    bool end = false;

    void Start()
    {
        currenthealth = startingHealth;
        currentScore = startScore;


        StartCoroutine("LoseTime");
    }

    void Update()
    {
        countdownText.text = ("" + timer);
        scoreText.text = ("" + currentScore);

        if(Input.GetKeyDown(KeyCode.Z))
        {
            DamageToPlayer();
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            AddScore();
        }

        if(timer <= 0 || currenthealth <= 0)
        {
            EndGame();


            Time.timeScale = 0;
        }

    }

    void DamageToPlayer()
    {
        currenthealth -= 10;

        healthBar.value = currenthealth;
    }

    void AddScore()
    {
        currentScore += 10;   
    }

    void EndGame()
    {
        StopCoroutine("LoseTime");
        countdownText.text = "0";

        fadeIn.SetTrigger("open");
    }


    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            timer--;
        }
    }
}
