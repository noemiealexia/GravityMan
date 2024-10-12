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

    public TextMeshProUGUI timeText;


    public void AddScore()
    {
        fruitsLeft++;
        fruitsText.text = fruitsLeft.ToString() + " / 8";

    }

    void Update()
    {

        if (fruitsLeft == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            fruitsLeft = 0;
        }
        
    }

}
