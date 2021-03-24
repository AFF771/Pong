using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float v = 5f;

    bool launch = false;
    float time;
    float AddTime;

    [SerializeField]
    float LaunchTime = 2f;

    [SerializeField]
    float angle = 0.5f;

    float LaunchAngleXabs;
    
    public void Adjust ()
    {
        Debug.Log(GetComponent<Rigidbody2D>().velocity);
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
