using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontos : MonoBehaviour
{
    public TMP_Text textoPontos;
    public int pontuacao; 
    void  Awake ()
    {
        textoPontos.text = "";
        ComportamentoAsteroid.EventoAsteroidDestruido += AsteroidDestruido;
    }


   void OnDestroy()
    {
        ComportamentoAsteroid.EventoAsteroidDestruido -= AsteroidDestruido;
    }
  
  
    void AsteroidDestruido()
    {
        
        Debug.Log("Asteroid Destruído!");
    }


    void  AtualizacaoTextoPontos ()
    {
        textoPontos.text = pontuacao.ToString();
    }
}
