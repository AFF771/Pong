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

    void Start()
    {
    }

    void Update()
    {
        tempoAdicionar = Time.deltaTime;
        tempo += tempoAdicionar;
        Debug.Log(tempo);

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
