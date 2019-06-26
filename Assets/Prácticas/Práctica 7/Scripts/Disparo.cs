using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Rigidbody bala;
    public Transform cañon;
    public float fuerzadisparo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody balapos = Instantiate(bala, cañon.position, cañon.rotation) as Rigidbody;
            balapos.AddForce(cañon.forward * fuerzadisparo);
        }
    }
}
