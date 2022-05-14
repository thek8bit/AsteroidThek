using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroid : MonoBehaviour
{

    public static System.Action EventoAsteroidDestruido = null;
    public Rigidbody2D  asteroidRb;
    public ComportamentoAsteroid prefabAsteroidMenor;
    public float velocidadeMaxMeteoro = 100.0f;
    public GameObject projetil;
    public int quantidadeFragmentos = 2;

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




    /* Laços de Repetição */

    /* while loop or for Loop*/

    int i; //Inicialização da Variável --> Contador
    
    i = 0; //Passagem de valor a variável --> Contador
    while (i < quantidadeFragmentos)
    {
      Instantiate(prefabAsteroidMenor, asteroidRb.position, Quaternion.identity);
      i = i + 1;
    }
    if (EventoAsteroidDestruido != null)
    {
      EventoAsteroidDestruido();
    }
  }
    // pode ser dessa forma também:
    //for (int 1 = 0; 1 < quantidadeFragmentos; i++)
    //{
    // Instantiate(prefabAsteroidMenor, asteroidRb.position, Quaternion.identity);
    //}
}