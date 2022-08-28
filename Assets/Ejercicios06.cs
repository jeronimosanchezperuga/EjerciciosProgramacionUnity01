using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios06 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > 0)
        {
            Debug.Log("El número es positivo");
        }
        else if (num1 < 0)
        {
            Debug.Log("El número es negativo");
        }
        else
        {
            Debug.Log("El número es cero");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
