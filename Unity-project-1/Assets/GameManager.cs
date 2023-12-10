using System.Diagnostics;
using System;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UnityEngine.UI.Text sumText; 
    public int targetSum;
    private int currentSum;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        InitializeGame();
    }

    void InitializeGame()
    {
        // Set up initial conditions, generate target sum, etc.
        GenerateTargetSum();
    }

    void GenerateTargetSum()
    {
        targetSum = UnityEngine.Random.Range(10, 30); // Adjust range as needed
        UpdateTargetSumText();
    }

    void UpdateTargetSumText()
    {
        sumText.text = "Target Sum: " + targetSum;
    }

    public void CheckpointReached(int checkpointNumber)
    {
        currentSum += checkpointNumber;
        UpdateCurrentSumText();

        if (currentSum == targetSum)
        {
            // Player has reached the target sum, implement win logic
            UnityEngine.Debug.Log("You win!");
            // You can trigger a win screen or perform other actions here
            InitializeGame(); // Restart the game
        }
        else if (currentSum > targetSum)
        {
            // Player has exceeded the target sum, implement lose logic
            UnityEngine.Debug.Log("You lose!");
            UnityEngine.Debug.Log("You lose!");
            // You can trigger a lose screen or perform other actions here
            InitializeGame(); // Restart the game
        }
    }

    void UpdateCurrentSumText()
    {
        // Optionally, update UI to display the current sum
    }
}



