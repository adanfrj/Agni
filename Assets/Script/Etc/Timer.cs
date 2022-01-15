using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int countDownStartValue = 120;
   

    public GameObject gameOver;
    public GameObject healthUI;
    public Text timerUI;


    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        CountDownTimer();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void CountDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "" + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("CountDownTimer", 1.0f);
            gameOver.SetActive(false);
            healthUI.SetActive(true);
        }
        else 
        {
            timerUI.text = "GameOver!";
            gameOver.SetActive(true);
            healthUI.SetActive(false);

        }
    }

}
