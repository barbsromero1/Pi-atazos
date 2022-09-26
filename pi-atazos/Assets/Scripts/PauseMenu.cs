using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool activewristUI = false;
    public GameObject wristUi;

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (GameIsPaused)
    //        {
    //            Time.timeScale = 1f;
    //            GameIsPaused = false;
    //            // Resume();

    //        }
    //        else
    //        {
    //            Time.timeScale = 0f;
    //            GameIsPaused = true;
    //            // Pause();
    //        }
    //    }
    //}

    //public void Resume()
    //{
    //    pauseMenuUI.SetActive(false);
    //    Time.timeScale = 1f;
    //    GameIsPaused = false;
    //}

    //public void Pause()
    //{
    //    pauseMenuUI.SetActive(true);
    //    Time.timeScale = 0f;
    //    GameIsPaused = true;

    //}

    //public void LoadMenu()
    //{
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("Menu");
    //}

    //public void SettingsMenu()
    //{
    //    SceneManager.LoadScene("Settings");
    //}

    private void Start()
    {
        DisplayWristUI();
    }

    public void DisplayWristUI()
    {
        //pause
        if (GameIsPaused)
        {
            wristUi.SetActive(true);
            activewristUI = true;
            Time.timeScale = 1;
            GameIsPaused = true;
            Debug.Log("Pause"); 
        }
        else if (!GameIsPaused)//not pause
        {
            wristUi.SetActive(false);
            activewristUI = false;
            Time.timeScale = 0;
            GameIsPaused = false; 
        }
    }

    //Resume 
    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DisplayWristUI();
        }
    }

    public void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        //Application.Quit(); 
    }

}
