using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        TowerWrap();
        
    }

    void Move()
    {
        transform.Translate(-2f * Time.deltaTime, 0, 0);
    }

    void TowerWrap()
    {
        if (transform.position.x < -6.66)
        {
            transform.position = new Vector3(6.66f, 1.95f, 0);
        }
    }
}
