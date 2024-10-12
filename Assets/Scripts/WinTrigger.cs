using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{

    public Logic logic;

    private void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.stopTimer = true;
        logic.KeepHighScore();


    }

    public void BackToMain()
    {
        logic.ResetTimer();
        SceneManager.LoadScene(0);

    }
}
