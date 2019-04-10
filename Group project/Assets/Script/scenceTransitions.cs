using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenceTransitions : MonoBehaviour
{
    public Animator transitionAnimator;

    public string scence;

    private float time = 0f;

    private void Start()
    {
        
    }

    void Update()
    {

        time += Time.deltaTime;

        if (time > 3)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transitionAnimator.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scence);
    }
}
