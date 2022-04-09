using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public float aceleracao = 3.0f;
    public Rigidbody2D jogadorRb;
    public float rotacao = 180.0f;
    public float velocidadeMaxima = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (0.0f, 0.0f, 0.0f); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * aceleracao;
            jogadorRb.AddForce(direcao, ForceMode2D.Force);
        }
        
        if (Input.GetKey(KeyCode.D))
    {
        jogadorRb.rotation +=   rotacao * Time.deltaTime;

    }

          if (Input.GetKey(KeyCode.A))  
    {
        jogadorRb.rotation -=   rotacao * Time.deltaTime;

    }
    
    if (jogadorRb.velocity.magnitude > velocidadeMaxima)
    
    {
         jogadorRb.velocity = Vector2.ClampMagnitude (jogadorRb.velocity, velocidadeMaxima);

    }


    

    }
}
