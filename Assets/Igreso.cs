using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igreso : MonoBehaviour
{
    public string nombre;
    public int anio;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {

        if(nombre == "" && anio < 1 || anio > 5)
        {
            Debug.Log("Error");
        } else if(orientacion != "T" && orientacion != "M" && orientacion != "G" && orientacion != "H" && orientacion != "D")
        {
            Debug.Log("Solo se puede ingresar T, D, M, G, H");
        }
        else if (anio < 3)
        {
           Debug.Log("error. Usted esta en ciclo basico");
        } else
        {
            Debug.Log("Muchas gracias " + nombre);
        }



       
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
