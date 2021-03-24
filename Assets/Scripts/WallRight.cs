using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRight : MonoBehaviour
{
    [SerializeField]
    ScoreKeeper ScoreKeeper;

    //Camel case -> métodos/ classes
    //pascal case -> variáveis

    private void OnCollisionEnter2D (Collision2D colision)
    {
        ScoreKeeper.GoalRight();
    }

}
