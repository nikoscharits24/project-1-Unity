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

    //audio
    public AudioSource audioSource;
    public AudioClip winSound;
    public AudioClip loseSound;

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
        targetSum = UnityEngine.Random.Range(10, 15);
        UpdateTargetSumText();
        return targetSum;


    }

    public void UpdateTargetSumText()
    {
        sumText.text = "Target Sum: " + targetSum;
        //sumText.text = ScoreManager.instance.

    }

    public void CheckpointReached(int checkpointNumber)
    {
        currentSum += checkpointNumber;
        

        if (currentSum == targetSum)
        {
            // Player has reached the target sum, implement win logic
            UnityEngine.Debug.Log("You win!");
            PlayWinSound();
            InitializeGame();
        }
        else if (currentSum > targetSum)
        {
            // Player has exceeded the target sum, implement lose logic
            UnityEngine.Debug.Log("You lose!");
            PlayLoseSound();
            InitializeGame();
        }
    }


    //sounds
    void PlayWinSound()
    {
        if (audioSource != null && winSound != null)
        {
            UnityEngine.Debug.Log("Playing win sound.");
            audioSource.PlayOneShot(winSound);
        }
        else
        {
            UnityEngine.Debug.LogWarning("AudioSource or WinSound is not assigned.");
        }
    }


    void PlayLoseSound()
    {
        if (audioSource != null && loseSound != null)
        {
           UnityEngine.Debug.Log("Playing lose sound.");
            audioSource.PlayOneShot(loseSound);
        }
        else
        {
           UnityEngine.Debug.LogWarning("AudioSource or LoseSound is not assigned.");
        }
    }

}



