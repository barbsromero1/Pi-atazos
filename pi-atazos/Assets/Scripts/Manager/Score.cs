using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score; 

    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.GetInt("HighScore", score);
        }
    }
}
