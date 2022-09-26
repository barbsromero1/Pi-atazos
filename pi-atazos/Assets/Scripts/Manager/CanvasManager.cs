using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public bool GameIsPaused;

    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            Time.timeScale = 0;
            Debug.Log("Pause"); 
        }
        if (!GameIsPaused)
        {
            Time.timeScale = 1;
            Debug.Log("UnPause");
        }
    }
}
