using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igreso : MonoBehaviour
{
    public string nombre;
    public int año;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {


        if(nombre == "" )
        {
            Debug.Log("Rellenar campo de nombre");

        }
        else
        {
            Debug.Log("¡Hola " + nombre + "!");
        }

        if(año >= 1 & año <= 5)
        {
            Debug.Log("Usted esta en " + año + " año");
        }
        else
        {
            Debug.Log("se utilizan numeros del 1 al 5");
        }

        if(orientacion != "D" & orientacion != "T" & orientacion != "G" & orientacion != "M" & orientacion != "H")
        {
            Debug.Log("Solo se pueden utilizar las letras D,T,G,M,H");
        }
        else
        {
            switch (orientacion)
            {
                case "D": Debug.Log("Usted esta en la orientacion  Diseño");
                    break;
                case "T":
                    Debug.Log("Usted esta en la orientacion  Tic");
                    break;
                case "G":
                    Debug.Log("Usted esta en la orientacion  Gestion");
                    break;
                case "M":
                    Debug.Log("Usted esta en la orientacion  Medios");
                    break;
                case "H":
                    Debug.Log("Usted esta en la orientacion  Humanidades");
                    break;



            }

        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
