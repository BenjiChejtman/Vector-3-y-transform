using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script : MonoBehaviour //no poner nombre de palabra reservada en nombre de script o nombre de variable o algo asi, cuidado con no repetir o usar nombres reservados que pueden arruinar el script.
{
    public Vector3 myVector3; //creo un vector con sus distintos ejes, 
                              //combino distintos ejes en una misma cosa,
                              //y eso se hace escribiendo esta linea que acabo de escribir. Se usa para expresar valorers en 3 ejes, X, Y y/o Z.

    public GameObject myObject; //clases = conuntos de metodos y variables o propiedades, nostros lo vamos a usar como un contenedor para guardar un objeto adentro.
    
    // Start is called before the first frame update
    void Start()
    {
       // myObject.transform.position = myVector3; //valor del transform(position) del objeto  sea igual a myvector 3
        //myObject.transform.localScale = myVector3; //para cambiar scale/scala (as unidas reprrsentan esto 1 = 100%
        myObject.transform.eulerAngles = myVector3; //cambiar rotacion.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
