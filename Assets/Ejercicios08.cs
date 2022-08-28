using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios08 : MonoBehaviour
{
    public int nroDia;

    // Start is called before the first frame update
    void Start()
    {
        if (nroDia<1 || nroDia>7)
        {
            Debug.Log("El día ingresado no es válido");
        }else if (nroDia == 1)
        {
            Debug.Log("Domingo");
        }
        else if (nroDia == 2)
        {
            Debug.Log("Lunes");
        }
        else if (nroDia == 3)
        {
            Debug.Log("Martes");
        }
        else if (nroDia == 4)
        {
            Debug.Log("Miércoles");
        }
        else if (nroDia == 5)
        {
            Debug.Log("Jueves");
        }
        else if (nroDia == 6)
        {
            Debug.Log("Viernes");
        }
        else if (nroDia == 7)
        {
            Debug.Log("Sábado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
