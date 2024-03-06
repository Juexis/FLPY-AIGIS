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

    int newHighScore;
    public void Setup(int score, int highscore) // method for the gameoverscreen
    {
        gameObject.SetActive(true); // makes the gameoverscreen visible
        currentScore.text = "Current Score: \n\n" + score;
        if (newHighScore < highscore) 
        {
            newHighScore = highscore;
        }
        highScore.text = "High Score: \n\n" + newHighScore;
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
