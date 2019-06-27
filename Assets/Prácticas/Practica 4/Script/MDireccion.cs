/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función simular el comportamiento de ataque de un enemigo a un jugador, por 
 lo que un objeto se acercará a otro al identificarlo

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDireccion : MonoBehaviour
{
    //Se declara la velocidad el enemigo en cuestión y cuál será su objetivo
    float velocidad;
        Transform objetivo;
    // Start is called before the first frame update

        //Se le asigna un valor numérico a la velocidad del perseguidor y se le asigna un objetivo (presa)
    void Start()
    {
        velocidad = 0.5f;
        objetivo = GameObject.Find("tesoro").GetComponent<Transform>();
        Debug.Log(objetivo.name);
        Vector3 dir = objetivo.position - this.transform.position;
        Debug.Log(dir.magnitude);
    }

    // Update is called once per frame

        //Se le indica al perseguidor que debe seguir a su objetivo a través del espacio respetando su velocidad
    void Update()
    {
        Vector3 dir = objetivo.position - this.transform.position;
        if(dir.magnitude > 1)
        {
            this.transform.Translate(dir.normalized * velocidad, Space.World);
        }
        
    }
}
