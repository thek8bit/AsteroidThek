using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
        public float velocidade = 5.0f;

        public GameObject prefabMeteoro;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, velocidade * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f,- velocidade * Time.deltaTime, 0.0f);   

        }

     /* if (Input.GetKey(KeyCode.A))
        { 
            transform.rotation = transform.rotation + new Vector3 (0.0f,  0.0f, 5.0f * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.D))
        { 
            transform.rotation = transform.rotation + new Vector3 (0.0f,  0.0f, -5.0f * Time.deltaTime);

        } 

    if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabMeteoro, new Vector3 (3.0f, 3.0f, 0.0f),Quaternion.identity);   

        }
        */
    }
}
