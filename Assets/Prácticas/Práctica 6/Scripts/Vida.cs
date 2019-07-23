/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un valor numérico ligado a un objeto y que represente su "vida"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Primero se declara una variable que represente la vida

public class Vida : MonoBehaviour
    //La vida se vincula con una caja de texto para poder observar sus cambios
{
    public float vida;
    public Text vidaText;

    private void Start()
    {
        vidaText.text = vida.ToString();
    }

    private void Update()
    {
        vidaText.text = vida.ToString();
    }

    
}




