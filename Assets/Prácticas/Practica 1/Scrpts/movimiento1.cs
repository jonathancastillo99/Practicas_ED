/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle movimientos en cierta dirección al objetos
 tras pasar cierta cantida de tiempo.
 
 
 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se declara una variable para asignarle movimiento al objeto
public class movimiento1 : MonoBehaviour
{
    #region Variables
    float velocidad = 3f;
    public float tiempo = 0f;
    #endregion

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

        // Se le asigna un tiempo y una valocidad al objeto que va a despegar
    void Update()
    {
        tiempo += 0.5f * Time.deltaTime;

        if (tiempo >= 2.5f)

        {
            transform.Translate(Vector3.forward * velocidad);
        }


    }
} //fin de la clase movimiento

