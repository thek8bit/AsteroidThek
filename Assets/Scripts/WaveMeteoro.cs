using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMeteoro : MonoBehaviour
{
    public ComportamentoAsteroid prefabmeteoro1;
    public int quantidadeAsteroids = 3;
    void Start()
    {
        for (int i = 0; i < quantidadeAsteroids; i++)//Laço de Repetição 'for (ESTUDEM!!!)
        {
            float  x = Random.Range(-11.0f, 11.0f);
            float  y = Random.Range(-5.0f, 5.0f);
        Vector3 posicao = new Vector3(x, y, 0.0f);
        Instantiate(prefabmeteoro1, posicao, Quaternion.identity);
        }
    }

    
    void Update()
    {
        
    }
}
