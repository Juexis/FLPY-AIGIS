using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerMovement : MonoBehaviour
{
    float randomY;
    float randomX;
    // Start is called before the first frame update
    void Start()
    {
        float randomY = Random.Range(0.34f, 4.35f);
        float randomX = Random.Range(3.75f, 13.37f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        TowerWrap();
        
    }

    void Move()
    {
        transform.Translate(-3f * Time.deltaTime, 0, 0);
    }

    void TowerWrap()
    {
        if (transform.position.x < -6.66)
        {
            transform.position = new Vector3(4f + randomX, randomY, 0); // sets a random range for the y-axis of the towers
        }
    }
}
