using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroid : MonoBehaviour
{

    public Rigidbody2D  asteroidRb;
    public float velocidadeMaxMeteoro = 100.0f;
    public GameObject projetil;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle; 
        direcao = direcao * velocidadeMaxMeteoro;
        asteroidRb.velocity = direcao;
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D projetil)
    {
      Destroy(gameObject);
      Destroy(projetil.gameObject);
    }
}
