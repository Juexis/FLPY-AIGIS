using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class aigisLogic : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpForce; // positive y-value
    bool flapping;
    bool gameOver;
    int score = 0;
    int highScore;
    public TextMeshProUGUI scoreDisplay;
    public gameOverScreen GameOverScreen;

    void Start()
    {
        scoreDisplay.text = score.ToString();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Update()
    {

        if (!gameOver)
        {
            Flap();
        }
        else
        {
            GameOver();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        string otherTag = otherObject.gameObject.tag; // creates otherTag variable (local)

        Debug.Log(otherTag);

        switch (otherTag) 
        {
            case "obstacle": // if collision with Obstacle tag, game is over
                GameOver();
                break;
        
        }
    }

    private void OnTriggerEnter2D(Collider2D otherTrigger)
    {
        switch (otherTrigger.name) 
        {
            case "scorefield":
                score++;
                scoreDisplay.text = score.ToString();
                break;
        }
    }


    void Flap()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // if LMB is pressed
        {
            flapping = true;
            body.velocity = new Vector2(0, jumpForce);
        }
        else
        {
            flapping = false;
        }
    }

    public void GameOver()
    {
        gameOver = true;
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", Score); // sets the HighScore variable of the PlayerPrefs document if score is greater than the PlayerPref's HighScore
        }
        GameOverScreen.Setup(score, highScore); // calling the Game Over sequence from the gameOverScreen script and assigning score value to scores
    }

    public bool getGameOver // GETTER METHOD DOESN'T REQUIRE PARENTHESIS
    {
        get { return gameOver; }
    }

    public int Score
    {
        get { return score; }
    }
}
