/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un movimiento a un tanque que tenga como
 entrada las teclas (W, A, S, D)

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movtank : MonoBehaviour
    //Se declara una variable que le asigne velocidad al objeto a mover
{
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
        //A cada tecla se le asigna una transformación que consiste en el aumento o disminución del valor de la velocidad en un eje determinado
    {

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -velocidad) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, velocidad) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocidad, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-velocidad, 0, 0) * Time.deltaTime);
        }
    }
}