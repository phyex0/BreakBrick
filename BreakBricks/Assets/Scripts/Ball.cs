using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 3f ;
    [SerializeField] float yPush = 16f ;
    Vector2 paddleToBall;
    bool isStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStarted){
            Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
            transform.position = paddlePosition + paddleToBall ;

            if (Input.GetMouseButtonDown(0))
            {
                isStarted = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            }
        }
    }
}
