using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public bool GameIsPaused;
    public bool GameIsOver;

    public GameObject gaveOverCanvas; 
    public GameObject score_time;
    public TimeManager TimeM;

    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false; 
        GameIsOver = false;
        gaveOverCanvas.SetActive(false);
        score_time.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            Time.timeScale = 0;
        }
        if (!GameIsPaused)
        {
            Time.timeScale = 1;
        }
    }

    public void GameOver()
    {
        TimeM.timeRemaining = 0;
        Time.timeScale = 0;
        gaveOverCanvas.SetActive(true);
        GameIsOver = true;
        score_time.SetActive(false);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Re-loaded Scene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}