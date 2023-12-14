using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text deathText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        deathText.text = "Maths is hard, right?";
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
