/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle a un objeto la función de un proyectil

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
    //Se declara qué objeto será el proyectil, de dónde saldrá y con qué fuerza
{
    public Rigidbody bala;
    public Transform cañon;
    public float fuerzadisparo;

    // Update is called once per frame
    void Update()
        //Se declara que al tocar el botó izquierdo del mouse, el proyectil saldrá dsiparado desde otro objeto aplicando el valor de fuerza establecido
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody balapos = Instantiate(bala, cañon.position, cañon.rotation) as Rigidbody;
            balapos.AddForce(cañon.forward * fuerzadisparo);
        }
    }
}
