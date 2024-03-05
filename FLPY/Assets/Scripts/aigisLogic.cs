using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aigisLogic : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpForce; // positive y-value
    public bool flapping;

    void Start()
    {
        
    }

    void Update()
    {
        Flap();
        
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
}
