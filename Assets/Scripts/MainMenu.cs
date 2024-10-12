using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public float timeScore;
    public TextMeshProUGUI highScore;

    public void Start()
    {
        timeScore = PlayerPrefs.GetFloat("HighScore", 0);
        int minutes = Mathf.FloorToInt(timeScore / 60);
        int seconds = Mathf.FloorToInt(timeScore % 60);
        highScore.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
