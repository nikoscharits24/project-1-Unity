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
        targetscore = GameManager.instance.GenerateTargetSum();
        scoreText.text = $"{score.ToString()} POINTS";
        targetScoreText.text = $"TARGET SCORE: {targetscore.ToString()}";

    }

    public void AddPoint(int checkpointNumber)
    {
        score += checkpointNumber;
        scoreText.text = score.ToString() + " POINTS";
    }
}
