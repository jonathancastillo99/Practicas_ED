/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un valor numérico al daño que recibirá un 
 jugador tras ser tocado por un enemigo

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoPlayer : MonoBehaviour
    //Se declara la variable de la vida del jugador y se le asigna al objeto que lo representa
{
    Vida vidajugador;

    void Start()
    {

            vidajugador = GameObject.Find("Player").GetComponent<Vida>();

    }

    //Se indica que cuando el jugador sea impactado por el enemigo, el valor asignado a la vida disminuya en tres unidades
    private void OnCollisionEnter(Collision collision)
    {


     if(collision.gameObject.tag=="Player")
        {
            vidajugador.vida -= 3;
        }

    }


}
