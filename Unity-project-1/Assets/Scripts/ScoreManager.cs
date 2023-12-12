using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{ 
    public static ScoreManager instance;

    public Text scoreText;
    public Text targetScoreText;
    int score = 0;
    int targetscore = 0;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        
        scoreText.text = $"{score.ToString()} POINTS";
        targetScoreText.text = $"TARGET SCORE: {targetscore.ToString()}";

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
