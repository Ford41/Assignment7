using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void StartGame()
    {
        Score.score = 0;
        Score.numSliced = 0;
        Score.numMissed = 0;
        SceneManager.LoadScene("Main");
    }

    public void HighscoreMenu()
    {
        SceneManager.LoadScene("HighScores");
    }

    public void EndMenu()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        Debug.Log("You Left");
        Application.Quit();
    }
}
