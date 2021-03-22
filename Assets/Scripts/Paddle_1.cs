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

    //double - 16 casas decimais (requer mais computação)
    //float - 8 casas decimais

   
    void Update()
     {
      
       if (Input.GetKey(upKey))
         {
            //sobe
            // >> x = x0 + v0 * (x,y,z) * t <<

            transform.position += velocidade * Vector3.up * Time.deltaTime;

            //sem o fator "Time.deltaTime" o movimento depende dos frames por segundo do computador!!
         }
       else if (Input.GetKey(downKey))
         {
            //desce
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