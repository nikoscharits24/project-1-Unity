using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverWin : MonoBehaviour
{
    public Text winText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        winText.text = "I guess you're a Genius!";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

