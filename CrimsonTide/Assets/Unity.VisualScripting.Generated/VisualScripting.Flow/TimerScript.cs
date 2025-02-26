using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using System.Collections;


public class TimerScript : MonoBehaviour
{
    //Time TBD
    public float timeRemaining;
    public TMP_Text timerText;
    public bool isPaused = false;
    private object Timer;
  

    private void Start()
    {
        timeRemaining = timeRemaining * 60;
    }

    void Update()
    {
        
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            GameOver();
        }

  
      TimeSpan time = TimeSpan.FromSeconds(timeRemaining);
        timerText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    void UpdateTimerText()
    {
        timerText.text = Mathf.Ceil(timeRemaining).ToString();
    }

    void GameOver()
    { 
        SceneManager.LoadScene(3);

    }
  
}
