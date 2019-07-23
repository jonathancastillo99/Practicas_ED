using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{

    //Se vinculan códigos
    TorretaDisp TorretaRadar;

    // Start is called before the first frame update
    void Start()
    {
        TorretaRadar = GetComponentInParent<TorretaDisp>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TorretaRadar.estadoActual = TurretIA.Ataque;
            StartCoroutine(TorretaRadar.MisilesAtaque());
            Debug.Log("Disparando");
        }
    }
}
