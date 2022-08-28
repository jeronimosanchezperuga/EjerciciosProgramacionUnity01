using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios11 : MonoBehaviour
{
    public string operacion;
    public int operando1;
    public int operando2;

    // Start is called before the first frame update
    void Start()
    {
        if (operacion == "s" || operacion == "r" || operacion == "p" || operacion == "d")
        {
            if (operacion == "s")
            {
                Debug.Log(operando1 + operando2);
            }
            else if (operacion == "r")
            {
                Debug.Log(operando1 - operando2);
            }
            else if (operacion == "p")
            {
                Debug.Log(operando1 * operando2);
            }
            else if (operacion == "d")
            {
                Debug.Log(operando1 / operando2);
            }
        }
        else
        {
            Debug.Log("Operación ingresada no válida");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
