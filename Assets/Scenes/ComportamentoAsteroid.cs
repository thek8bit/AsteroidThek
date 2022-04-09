using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroid : MonoBehaviour
{

    public Rigidbody2D  asteroidRb;
    public float velocidadeMaxMeteoro = 10.0f;
    public int pontos;

    // Start is called before the first frame update
    void Start()
    {
         Vector2 direcao = Random.insideUnitCircle; 
        direcao = direcao * velocidadeMaxMeteoro;
        asteroidRb.velocity = direcao;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
