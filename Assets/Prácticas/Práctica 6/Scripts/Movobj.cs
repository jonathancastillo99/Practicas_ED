/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un movimiento a un objeto mediante 
 entradas del teclado (W, A, S, D)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movobj : MonoBehaviour

    //Se declara una variable para que el objeto se mueva a cierta velocidad
{
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

        /*Se le asigna una tecla a cada movimiento; para esto, se toman en cuenta los ejes en los que se moverá el objeto, dependiendo de la dirección, 
         será el eje em el que se pondrá la variable velocidad ya sea positiva o negativa

         */
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -velocidad, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, velocidad, 0) * Time.deltaTime);
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
