using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aigisLogic : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpForce; // positive y-value
    public bool flapping;
    public bool gameOver;

    void Start()
    {
        
    }

    void Update()
    {
        //if (!gameOver)
        {
            Flap();
        }
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        string otherTag = otherObject.gameObject.tag; // creates otherTag variable (local)

        Debug.Log(otherTag);

        switch (otherTag) 
        {
            case "obstacle": // if collision with Obstacle tag, game is over
                gameOver = true; 
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

    public bool GameOver // GETTER METHOD DOESN'T REQUIRE PARENTHESIS
    {
        get { return gameOver; }
    }
}
