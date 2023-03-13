using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField]  private TextMeshProUGUI highScoreText;

    private int score = 0;
    private int HighScore;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
       
        CollectHighScore();
    }

    private void CollectHighScore()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "HighScore : " + HighScore.ToString();
    }



    public void AddScore()
    {
        score += 20;
        scoreText.text = "Score : " + score.ToString();
        GetHighScore();
    }

    private void GetHighScore()
    {
        if(HighScore < score)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    

    
}
