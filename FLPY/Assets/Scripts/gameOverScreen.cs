using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI currentScore; // reference to Current Score Object
    public TextMeshProUGUI highScore; // reference to High Score Object
    int HighScore;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    public void Setup(int score, int highscore) // method for the gameoverscreen
    {
        gameObject.SetActive(true); // makes the gameoverscreen visible
        currentScore.text = "Current Score: \n\n" + score;
        highScore.text = "High Score: \n\n" + HighScore;
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
