using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
    
{
    public GameObject[] tanqueEnemigo;
    public GameObject[] almacenTanques;
    public GameObject explosionTanque;


    // Start is called before the first frame update
    void Start()
    {
        //Singular y plural 
        tanqueEnemigo = GameObject.FindGameObjectsWithTag("tanqueEnemigo");
        almacenTanques = new GameObject[tanqueEnemigo.Length];
        for (int i = 0; i <tanqueEnemigo.Length; i++)
        {
             almacenTanques[i] = tanqueEnemigo[i];
        }
    }

// Update is called once per frame
void Update()
  {

    if (Input.GetKeyDown(KeyCode.Space)) ;

    {
            for (int i = 0; i < almacenTanques.Length; i++)
            {
                Instantiate(explosionTanque, almacenTanques[i].transform.position, almacenTanques[i].transform.rotation);
                Destroy(almacenTanques[i]);
            }
           
    }
  }
}

    