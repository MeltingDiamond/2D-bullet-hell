using System;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
  
    public static ScoreManager instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    { 
        score++;
        scoreText.text = "Score: " + score;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
