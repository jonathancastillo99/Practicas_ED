/*
 Jonathan Castillo
 Materia: Estructura de datos
 Grupo: DAA06A
 Profesor: Josue Isarel Rivas Días
 Descripción breve de funcionamiento de codigo: El código tiene como función asignarle un movimiento definido a un cubo.
 éste debe moverse siguiendo una secuencia de distancias establecidas.

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Se debe declarar una variable que contenga la velocidad del objeto, una que esyablezca un límite entre el movimiento y los puntos
y un par de booleanos para poder condicionar dichos límites

*/

public class MovX : MonoBehaviour
{   float velocidad = 0.3f;
    int tope = 4;
    bool direccion, direccion2;
    //Al principio se declara que la dirección es verdadera (como si se tratara de encendido)
   private void Start()
{
    direccion = true;

}
// Update is called once per frame
//Se condiicona al booleano para que al exceder el valor del tope en el eje x, el booleano cambie a falso
void Update()
    {

    if (direccion == true)
    {
        if (transform.position.x < tope)
        {
            transform.Translate(Vector3.right * velocidad);
        }

        if (transform.position.x >= tope)
        {
            direccion = false;
        }

    }
    //Tras haber cambiado a falso, se condiciona el booleano para que vuelva a cambiar al exceder otro límite
        if (direccion == false)
        {
            if (transform.position.y < 6)
            {
                transform.Translate(Vector3.up * velocidad);
            }
            if (transform.position.y >= 6)
            {
                direccion2 = true;
            }
        }

        //En este punto, se requiere de un booleano nuevo, pues las opciones del anterior ya fueron utilizadas (empieza como verdadero)

        if (direccion2 == true)
        {
            if (transform.position.x >= 0)
            {
                transform.Translate(Vector3.left * velocidad);
            }
            if (transform.position.x <= 0)
            {
                direccion2 = false;
            }
        }


//El segundo booleano se vuelve falso al exceder el tope establecido de nuevo en x y baja en el eje y

        if (direccion == false)
        {
            if (transform.position.x <= 0)
            {
                transform.Translate(Vector3.down * velocidad);
            }
            if (transform.position.y <= 0)
            {
                direccion = true;
            }
        }

    }
}

