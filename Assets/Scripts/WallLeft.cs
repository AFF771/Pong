using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLeft : MonoBehaviour
{
    [SerializeField]
        ScoreKeeper ScoreKeeper;


    [SerializeField]
        Paddle Paddle_1;

    [SerializeField]
        Paddle Paddle_2;

    //Camel case -> métodos/ classes
    //pascal case -> variáveis

    private void OnCollisionEnter2D (Collision2D colision)
    {       
        ScoreKeeper.GoalLeft();
        Paddle_2.PaddleReset();
        Paddle_1.PaddleReset();
    }

}
