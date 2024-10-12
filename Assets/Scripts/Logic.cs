using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int fruitsLeft;
    public TextMeshProUGUI fruitsText;

    public float elapsedTime;
    public TextMeshProUGUI timeText;

    public bool stopTimer;


    private void Start()
    {
        stopTimer = false;

        if (PlayerPrefs.HasKey("timeValue"))
        {
            elapsedTime = PlayerPrefs.GetFloat("timeValue");
        }

    }

    public void AddScore()
    {
        fruitsLeft++;
        fruitsText.text = fruitsLeft.ToString() + " / 8";

    }

    public void KeepHighScore()
    {
        if (elapsedTime < PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", elapsedTime);
        }
    }

    public void ResetTimer()
    {
        elapsedTime = 0;
        PlayerPrefs.SetFloat("timeValue", elapsedTime);
    }

    void Update()
    {
        if (!stopTimer)
        {
            elapsedTime += Time.deltaTime;
            PlayerPrefs.SetFloat("timeValue", elapsedTime);
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if (fruitsLeft == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            fruitsLeft = 0;
        }
        
    }




}
