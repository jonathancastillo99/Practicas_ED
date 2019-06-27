/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un movimiento definido a un cubo.
El cubo se moverá haciendo uso de las teclas W, A, S, D

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movcub : MonoBehaviour
    //Se declara una variable que será la velocidad a la que el cubo va a moverse
{
    public float velocidad;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    /*
         A cada tecla en custión se le asignará una transformación; ésta reemplazará el valor de un eje por la variable de velocidad,
         alternándose entre valores positivos y negativos para desplazar al cubo en el espacio

    */
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