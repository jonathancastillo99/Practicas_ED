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

//Se crea una variable que almacene el movimiento a realizar por el objeto
public class movimiento2 : MonoBehaviour
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

        //Se asina una velocidad y tiempo al tercer objeto, la dirección es "adelante"
    void Update()
    {
        tiempo += 0.5f * Time.deltaTime;

        if (tiempo >= 3.5f)

        {
            transform.Translate(Vector3.forward * velocidad);
        }


    }
} //fin de la clase movimiento
