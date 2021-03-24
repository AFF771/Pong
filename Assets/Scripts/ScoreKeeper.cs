using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    int RightScore = 0;
    int LeftScore = 0;

    [SerializeField]
        Text ScoreLeft;

    [SerializeField]
        Text ScoreRight;

    public void GoalRight()
    {
            // left player score
        LeftScore += 1;
        ScoreLeft.text = "" + LeftScore;
        //Debug.Log(LeftScore + " : " + RightScore);
    }
    
    public void GoalLeft()
    {
            // right player score
        RightScore += 1;
        ScoreRight.text = "" + RightScore;
        //Debug.Log(LeftScore + " : " + RightScore);
    }
}
