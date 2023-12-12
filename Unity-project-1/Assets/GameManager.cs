using System.Diagnostics;
using System;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UnityEngine.UI.Text sumText; 
    public int targetSum;
    private int currentSum;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        InitializeGame();
    }

    void InitializeGame()
    {
        GenerateTargetSum();
    }

    public int GenerateTargetSum()
    {
        targetSum = UnityEngine.Random.Range(10, 30);
        UpdateTargetSumText();
        return targetSum;
        
      
    }

    public void UpdateTargetSumText()
    {
        sumText.text = "Target Sum: " + targetSum;
        //sumText.text = ScoreManager.instance.Start();
        
    }

    public void CheckpointReached(int checkpointNumber)
    {
        currentSum += checkpointNumber;
        UpdateCurrentSumText();

        if (currentSum == targetSum)
        {
            // Player has reached the target sum, implement win logic
            UnityEngine.Debug.Log("You win!");
         
            InitializeGame(); // Restart the game
        }
        else if (currentSum > targetSum)
        {
            // Player has exceeded the target sum, implement lose logic
            UnityEngine.Debug.Log("You lose!");
            UnityEngine.Debug.Log("You lose!");
           
            InitializeGame(); // Restart the game
        }
    }

    void UpdateCurrentSumText()
    {
        
    }
}



