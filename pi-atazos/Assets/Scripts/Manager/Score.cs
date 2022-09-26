using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    public TextMeshPro highScoreText;
    public TextMeshPro scoreText;
    public TextMeshPro scoreTextOver;

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
        scoreTextOver.text = score.ToString();
        Debug.Log("score" + score);
    }
    void OnDestroy()
    {
        PlayerPrefs.Save();
    }
}
