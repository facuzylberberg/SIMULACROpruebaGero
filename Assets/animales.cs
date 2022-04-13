using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animales : MonoBehaviour
{
    public string inicialanimal;
    public int dias;
    // Start is called before the first frame update
    void Start()
    {
        int G = (dias * 300);
        int PP = (dias * 400);
        int PG = (dias * 700);
        int PrecioG = (G / 100 * 80);
        int PrecioPP = (PP / 100 * 80);
        int PrecioPG = (PG / 100 * 80);

        if(dias < 3)
        {
            Debug.Log("Error, el numero debe ser mayor a 3");

        }
        else if (inicialanimal != "G" & inicialanimal != "PP" & inicialanimal != "PG")
        {
            Debug.Log("Error, las letras disponibles sn G,PP o PG");
        }
        else if ( inicialanimal == "G")
        {
            Debug.Log("Para ese periodo se necesita " + G + " gramos de alimento");
            Debug.Log("Su total es de " + PrecioG + " pesos");

        }
        else if (inicialanimal == "PP")
        {
            Debug.Log("Para ese periodo se necesita " + PP + " gramos de alimento");
            Debug.Log("Su total es de " + PrecioPP + " pesos");

        }
        else if (inicialanimal == "PG")
        {
            Debug.Log("Para ese periodo se necesita " + PG + " gramos de alimento");
            Debug.Log("Su total es de " + PrecioPG + " pesos");
        }
        
        
        






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
