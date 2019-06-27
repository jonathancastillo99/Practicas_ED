/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle movimietnos en cierta dirección al objetos
 tras pasar cierta cantida de tiempo.

 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se declara una variable que pueda proporcionarle movimiento a un objeto

public class movimiento : MonoBehaviour
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

        //Este apartado funciona para que, después de cierto tiempo, el objeto se mueva hacia adelante a cierta velocidad
        
    void Update()
    {
        tiempo += 0.5f * Time.deltaTime;

        if (tiempo >= 1.5f)

        {
            transform.Translate(Vector3.forward * velocidad);
        }


    }
} //fin de la clase movimiento
