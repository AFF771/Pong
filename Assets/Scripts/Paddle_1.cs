using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_1 : MonoBehaviour
{
    [SerializeField]
        float velocidade = 0.5f;

    [SerializeField]
        KeyCode upKey = KeyCode.W;

    [SerializeField]
        KeyCode downKey = KeyCode.S;
   
    void Update()
     {
       if (Input.GetKey(upKey))
         {
            // x = x0 + v0 * (x,y,z) * t 
            transform.position += velocidade * Vector3.up * Time.deltaTime;
         }
       else if (Input.GetKey(downKey))
         {
            transform.position += velocidade * Vector3.down * Time.deltaTime;
         }

        float cameraheight = Camera.main.orthographicSize;
        float halfPaddlesize = 0.5f;

        // Clamp -> (valor, mínimo, máximo)
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(transform.position.y,
                        -cameraheight + halfPaddlesize, 
                        cameraheight - halfPaddlesize);
        transform.position = positionAux;


     }
    
}