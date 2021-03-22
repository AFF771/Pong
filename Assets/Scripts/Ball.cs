using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
        float velocidade = 5f;

    bool lançamento = false;
    float tempo;
    float tempoAdicionar;

    [SerializeField]
        float tempolançamento = 2f;

    void Update()
    {
        //---------------------Timer---------------------------------
        tempoAdicionar = Time.deltaTime;
        tempo += tempoAdicionar;
        Debug.Log("Time = " + (Mathf.Round(tempo*100f)/100f) + "s");
        //---------------------Timer---------------------------------

        if (lançamento == false)
        {
            if (tempo >= tempolançamento)
            {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
                lançamento = true;
            }
        }
    }
}
