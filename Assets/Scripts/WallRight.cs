using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRight : MonoBehaviour
{
    [SerializeField]
        ScoreKeeper ScoreKeeper;

    [SerializeField]
    Paddle Paddle_1;

    [SerializeField]
    Paddle Paddle_2;


    private void OnCollisionEnter2D (Collision2D colision)
    {
        ScoreKeeper.GoalRight();
        Paddle_2.PaddleReset();
        Paddle_1.PaddleReset();
    }

}
