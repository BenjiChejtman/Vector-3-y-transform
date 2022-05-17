using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) //muevo el objeto con la d para la derecha
        {
            transform.position += new Vector3(movementSpeed, 0, 0);   //podemos crear un vector3 de manera dinamica, utilizando new Vector3 con sus valores (X, Y, Z), son los que s enecuentra entre parentesis.   
        }
        if (Input.GetKey(KeyCode.A)) //muevo el objeto con la A para la izquierda
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);   //podemos crear un vector3 de manera dinamica, utilizando new Vector3 con sus valores (X, Y, Z), son los que s enecuentra entre parentesis.   
        }
        if (Input.GetKey(KeyCode.W)) //muevo el objeto con la W para arriba
        {
            transform.position += new Vector3(0, movementSpeed, 0);   //podemos crear un vector3 de manera dinamica, utilizando new Vector3 con sus valores (X, Y, Z), son los que s enecuentra entre parentesis.   
        }
        if (Input.GetKey(KeyCode.S)) //muevo el objeto con la S para bajo
        {
            transform.position -= new Vector3(0, movementSpeed, 0);   //podemos crear un vector3 de manera dinamica, utilizando new Vector3 con sus valores (X, Y, Z), son los que s enecuentra entre parentesis.   
        }
    }                                                 // f minuscula para aclar que es float y que nos tome el punto, sino tia error
}
