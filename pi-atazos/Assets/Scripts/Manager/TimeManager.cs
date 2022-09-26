using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TimeManager : MonoBehaviour
{
    public float timeRemaining = 90;
    public bool timeIsRunning = false;

    public CanvasManager canvas; 
    //public Text timeText; 

    private void Start()
    {
        timeIsRunning = true;
    }

    private void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timeIsRunning = false; 
            }
        }
        else
        {
            canvas.GameOver(); 
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; 
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    }
    void AddTime()
    {
        timeRemaining += 30;
    }
}
