/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un movimiento a un objeto por medio de puntos 
 para que este patrulle pero, al cercársele un enemigo pueda perseguirlo (cambio de estados)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se ponen los nombres del identificador de acción a utilizar

    //Se declara la variable que representará al enemigo y a sus distintos modos de acción
public enum EnemigoIA
{
Patrulla, Perseguir, Atacar
}

public class MovPuntosIA : MonoBehaviour
    //Se le asignará al enemigo una velocidad, movimiento y objetivo a perseguir
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    //esta almacena estado o ubicacion del jugador en el mapa
    public Transform player;
    public EnemigoIA EstadoActual = new EnemigoIA();
   

    // Start is called before the first frame update
    void Start()
    {

        EstadoActual = EnemigoIA.Patrulla;
        //Se convierte en el elemento inicial el indice 1
        target = puntos[1];
        //.position lee la posición
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;
        //distance va a medir la distancia emntre el objeto a mover y el objetivo 
        float distance = Vector3.Distance(sierra.position, target.position);

        float distancePlayer = Vector3.Distance(sierra.position, player.position);

        //Se va a trasladar tomando en cuenta la normalizacion de la velocidad midiendo su espacio en el mundo
        sierra.Translate(dir.normalized * velocidad, Space.World);

        //si la distancia es menor o igual a 0.5 se le suma uno a indice, que es el que indica hacia que punto se va a mover

        if (EstadoActual == EnemigoIA.Patrulla)
        {
            target = puntos[indiceTarget];

            if (distance <= 0.5f)
            {
                //.Length es para que el sistema lea la extensión total del array lee cada nunero o valor dentro del array desde 0 hasta 4
                //El -1 se obliga a que se lea solo hasta el último punto, no se sobrecarga el array
                if (indiceTarget >= puntos.Length - 1)
                {
                    indiceTarget = 0;
                    target = puntos[indiceTarget];
                }

                indiceTarget++;
                target = puntos[indiceTarget];
            }
        }
       
        if (distancePlayer <= 2)
        {
            EstadoActual = EnemigoIA.Perseguir;
        }

        else if (distancePlayer >5)
        {
            EstadoActual = EnemigoIA.Patrulla;
        }

        if (EstadoActual ==EnemigoIA.Perseguir)
        {
            target = player;
        }


    }
}
