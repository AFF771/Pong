using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]
        Text ScoreLeft;
    [SerializeField]
        Text ScoreRight;
    [SerializeField]
        Text RoundBoard;
    [SerializeField]
        Text LeftResult;
    [SerializeField]
        Text RightResult;

    [SerializeField]
        Ball Ball;

    [SerializeField]
        int RoundN;

    int CurrentRound = 0;

    int RightScore = 0;
    int LeftScore = 0;

    public void Start()
    {
        //Debug.Log("Roud: " + (CurrentRound + 1f) + " / " + LeftScore + " - " + RightScore);
    }

    public void GoalRight()
    {
        if ((CurrentRound+1f) >= RoundN)
        {
            LeftScore += 1;

            if (LeftScore>RightScore)
            {
                LeftResult.text = "Win";
                RightResult.text = "";
                //Debug.Log("Left won: " + LeftScore + "-" + RightScore);
            }
            else
            {
                LeftResult.text = "Draw";
                RightResult.text = "Draw";
                //Debug.Log("Draw: " + LeftScore + "-" + RightScore);
            }
            Ball.GameReset();
            RoundReset();
        }
        else
        {
            CurrentRound += 1;
            LeftScore += 1;
            ScoreLeft.text = "" + LeftScore;
            LeftResult.text = "";
            RightResult.text = "";
            RoundBoard.text = "Round: " + (CurrentRound + 1f);
            Debug.Log("Roud: " + (CurrentRound + 1f) + " / " + LeftScore + " - " + RightScore);

            Ball.Reset();
        }
    }
    
    public void GoalLeft()
    {
        if (CurrentRound+1f >= RoundN)
        {
            RightScore += 1;

            if (RightScore > LeftScore)
            {
                LeftResult.text = "";
                RightResult.text = "Win";
               //Debug.Log("Right Won: " + LeftScore + "-" + RightScore);
            }
            else
            {
                LeftResult.text = "Draw";
                RightResult.text = "Draw";
                //Debug.Log("Draw: " + LeftScore + "-" + RightScore);
            }

            Ball.GameReset();
            RoundReset();
        }
        else
        {
            CurrentRound += 1;
            RightScore += 1;
            ScoreRight.text = "" + RightScore;
            LeftResult.text = "";
            RightResult.text = "";
            RoundBoard.text = "Round: " + (CurrentRound + 1f);
            Debug.Log("Roud: " + (CurrentRound+1f) + " / " + LeftScore + " - " + RightScore);

            Ball.Reset();
        }
    }

    public void RoundReset()
    {
        LeftScore = 0;
        RightScore = 0;
        CurrentRound = 0;
        ScoreLeft.text = "" + LeftScore;
        ScoreRight.text = "" + RightScore;
        RoundBoard.text = "Round: " + 1f;
    }
}
