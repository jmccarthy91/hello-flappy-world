using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverScreen;
    public bool isGameOver = false;

    public static LogicScript logic;                                        //so that we can call public variables from here in other scripts

    public void Awake()
    {
        logic = this;
    }

    public void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0).ToString();     //pull the highScore
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)                                    //add points!
    {
        if (isGameOver == false)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
            FindObjectOfType<AudioManager>().Play("Coin");
        }

        if (playerScore > PlayerPrefs.GetInt("highScore", 0))               //if playerScore is higher than the highScore, update the highScore
        {
            PlayerPrefs.SetInt("highScore", playerScore);
            highScoreText.text = "High Score: " + playerScore.ToString();
        }
    }

    public void restartGame()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }
}
