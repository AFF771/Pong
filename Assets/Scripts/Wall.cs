using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    Ball Ball;

    private void OnCollisionEnter2D (Collision2D colision)
    {
        Ball.Adjust();
    }

}
