using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
        float v;
    [SerializeField]
        float LaunchTime = 2f;
    [SerializeField]
        float angle = 0.5f;

    bool launch = false;
    float time;
    float AddTime;
    float LaunchAngleXabs;

    public void Reset()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        Vector3 PositionAux = transform.position;
        PositionAux = Vector3.zero;
        transform.position = PositionAux;

        time = 0;
        launch = false;
        Update();
    }

    public void GameReset()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        Vector3 PositionAux = transform.position;
        PositionAux = Vector3.zero;
        transform.position = PositionAux;

        time = -2;
        launch = false;
        Update();
    }
        
    void Update()
    {
        //---------------------Timer---------------------------------
            AddTime = Time.deltaTime;
            time += AddTime;
        //Debug.Log("Time = " + (Mathf.Round(time*100f)/100f) + "s");
        //---------------------Timer---------------------------------

        if (launch == false)
        {
            if (time >= LaunchTime)
            {
                Vector3 LaunchAngle = Random.insideUnitCircle.normalized;
                    // LaunchAngleXabs -> absolute value of LAunchAngle.x
                LaunchAngleXabs = Mathf.Abs(LaunchAngle.x);
                    // angle -> cosine (x coordinate in unit circle)   
                if (LaunchAngleXabs > angle)
                {
                    GetComponent<Rigidbody2D>().velocity = v * LaunchAngle;
                        //Debug.Log(LaunchAngle.x + "x, " + LaunchAngle.y);
                        //Debug.Log(GetComponent<Rigidbody2D>().velocity);
                    launch = true;
                }
            }
        }
    }
}
