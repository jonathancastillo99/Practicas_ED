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

public enum TurretIA
{
    Buscando, Ataque
}

public class TorretaIA : MonoBehaviour
//Se declara qué objeto será el proyectil, de dónde saldrá y con qué fuerza
{
    public Rigidbody bala;
    public Transform[] cañon;
    public float fuerzadisparo;
    public TurretIA estadoActual = new TurretIA();
    int ContadorMisiles;



    void Start()
    {
        ContadorMisiles = 0;
        estadoActual = TurretIA.Buscando;
    }



    // Update is called once per frame
    void Update()
    //Se declara que al entrar en el modo de ataque, la torreta dispare
    {

        if (estadoActual == TurretIA.Ataque)
        {

            for (int i = 0; i < 3; i++)
            {
                Rigidbody balapos = Instantiate(bala, cañon[i].position, cañon[i].rotation) as Rigidbody;
                balapos.AddForce(cañon[i].forward * fuerzadisparo);
                //El contador de misiles aumenta en 1 para que alcance la condicionante de 3 
                ContadorMisiles = i + 1;

                if (ContadorMisiles >= 3 && i >= cañon.Length - 1)
                {
                    ContadorMisiles = 3;
                    estadoActual = TurretIA.Buscando;
                }

            }


        }
    }
}