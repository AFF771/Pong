using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
        float velocity = 0.5f;

    [SerializeField]
        KeyCode upKey = KeyCode.W;
    [SerializeField]
        KeyCode downKey = KeyCode.S;

    [SerializeField]
        Ball Ball;

    void Update()
     {
       if (Input.GetKey(upKey))
         {
            // x = x0 + v0 * (x,y,z) * t 
            transform.position += velocity * Vector3.up * Time.deltaTime;
         }

       else if (Input.GetKey(downKey))
         {
            transform.position += velocity * Vector3.down * Time.deltaTime;
         }

        float cameraheight = Camera.main.orthographicSize;
        float halfPaddlesize = 0.5f;

        // Clamp -> (value, min, max)
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(transform.position.y,
                        -cameraheight + halfPaddlesize, 
                        cameraheight - halfPaddlesize);
        transform.position = positionAux;
     }

    public void PaddleReset()
    {
        Vector3 positionAux = transform.position;
        positionAux.y = 0;
        transform.position = positionAux;
    }
}