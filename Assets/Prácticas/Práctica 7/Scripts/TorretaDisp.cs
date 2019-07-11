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

public class TorretaDisp : MonoBehaviour
//Se declara qué objeto será el proyectil, de dónde saldrá y con qué fuerza
{
    public Rigidbody bala;
    public Transform [] cañon;
    public float fuerzadisparo;
    public TurretIA estadoActual = new TurretIA();
    int ContadorMisiles;
    public int aumento = 0;



    void Start()
    {
        ContadorMisiles = 0;
        estadoActual = TurretIA.Buscando;

        StartCoroutine(MisilesAtaque());
    }



    // Update is called once per frame
    void Update()
    //Se declara que al entrar en el modo de ataque, la torreta dispare
    {

        if (estadoActual==TurretIA.Ataque)
        {

            ContadorMisiles = 0; 
         
        }
    }//fin update


    public IEnumerator MisilesAtaque()
    {
        if (estadoActual == TurretIA.Ataque)
        {
            Rigidbody balapos = Instantiate(bala[0], cañon[aumento].position, cañon[aumento].rotation) as Rigidbody;
            balapos.AddForce(cañon[aumento].forward * fuerzaDisparo);
            ContadorMisiles++;

            yield return new WaitForSeconds(1);
            aumento++;
            if (aumento == 8 && aumento > cañon.Length - 1)
            {
                aumento = 0;
            }

            if (ContadorMisiles != 9)
            {
                StartCoroutine(MisilesAtaque());
            }            else if (ContadorMisiles == 9)
            {
                estadoActual = TurretIA.Buscando;
            }

            yield return null;
        }


    }




}//fin clase






//yield permite generar cada linea de ación dividida y secuenciada 


  /*  for (int i = 0; i< 3; i++)
            {
                Rigidbody balapos = Instantiate(bala, cañon[i].position, cañon[i].rotation) as Rigidbody;
balapos.AddForce(cañon[i].forward* fuerzadisparo);
                //El contador de misiles aumenta en 1 para que alcance la condicionante de 3 
                ContadorMisiles = i + 1;

                if (ContadorMisiles >= 3 && i >= cañon.Length -1)
                {
                    ContadorMisiles = 3;
                    estadoActual = TurretIA.Buscando;
                }

            }*/