using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios09 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;

    // Start is called before the first frame update
    void Start()
    {
        int cantidadDadosSeis = 0;
        if (dado1 == 6)
        {
            cantidadDadosSeis ++;
        }
        if (dado2 == 6)
        {
            cantidadDadosSeis++;
        }
        if (dado3 == 6)
        {
            cantidadDadosSeis++;
        }

        if (cantidadDadosSeis == 3)
        {
            Debug.Log("Excelente");
        } else if (cantidadDadosSeis == 2)
        {
            Debug.Log("Muy bien");
        }
        else if (cantidadDadosSeis == 1)
        {
            Debug.Log("Regular");
        }
        else if (cantidadDadosSeis == 0)
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
