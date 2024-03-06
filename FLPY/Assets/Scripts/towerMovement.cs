using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerMovement : MonoBehaviour
{
    float randomY;
    float randomX;
    aigisLogic aigisScript;
    GameObject aigisObject;
    // Start is called before the first frame update
    void Start()
    {
        aigisObject = GameObject.Find("aigistoaster");
        aigisScript = aigisObject.GetComponent<aigisLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);
        //if (!aigisScript.GameOver)
        {
            Move();
            TowerWrap();
        }
    }

    void Move()
    {
        transform.Translate(-3f * Time.deltaTime, 0, 0);
    }

    void TowerWrap()
    {
            if (transform.position.x < -6.66)
            {
                float randomY = Random.Range(0.34f, 4.35f);
                float randomX = Random.Range(3.75f, 5.37f);
                transform.position = new Vector3(3f + randomX, randomY, 0); // sets a random range for the y-axis of the towers
            }
    }
}
