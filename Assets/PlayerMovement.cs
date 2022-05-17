using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;

    // Start is called before the first frame update
    void Start() //se ejecuta una sola vez al cominezo de la escena
    {
       
    }

    // Update is called once per frame
    void Update() //una vez por frame, se va a hacer constantemente cada frame
    {
        if (transform.position.y < 6) //mientras la posicion en y de mi transform sea menor a 6 que se mueva para arriba, si llega a 6 que pare.
        {
            transform.position += movement;             //* 10;                       //(el mas le suma el valor al valor original, en cambio sin el mas, solo se le asigna el valor qu epongamos en el inspector)(valor actual de position + movement, es decir, lo va a desplazar(a player)) accedo al componente transform, a la propiedad psoition y tomo el vakoir de movement y lo asigno a position.    
        }   //se detenga ates de salir de pantalla                                    //si hago referencia al transform, estoy haciebndo referencia la objeto que tenga transofrm aplicado, en este caso Player (cube).
                                                                                        //no le pongo un valor completo, es decir mayor a 1, porque si no se va a mover mucho. y se pued ecrasehar creo.
           
        //if (transform.eulerAngles.y < 160) //gira hasta 160 grados 
        //{
        //    transform.eulerAngles += movement;                                     //(el mas le suma el valor al valor original, en cambio sin el mas, solo se le asigna el valor qu epongamos en el inspector)(valor actual de position + movement, es decir, lo va a desplazar(a player)) accedo al componente transform, a la propiedad psoition y tomo el vakoir de movement y lo asigno a position.    
        //}

                            //transform.localScale += movement; //modifico scale, suma scala.

                            //transform.eulerAngles += movement; //modifico la rotacion, lo hace rotar.
    }
}
