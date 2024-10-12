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


    public void AddScore()
    {
        fruitsLeft++;
        fruitsText.text = fruitsLeft.ToString() + " / 8";

    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (fruitsLeft == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            fruitsLeft = 0;
        }
        
    }

}
