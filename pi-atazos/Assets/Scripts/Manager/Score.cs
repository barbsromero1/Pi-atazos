using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    public Text highScoreText;
    public Text scoreText;

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
            highScoreText.text = score.ToString();
        }
        scoreText.text = score.ToString();
    }
}
