using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 || num2 == num3 || num1 == num3)
        {
            Debug.Log("No se permiten números repetidos");
        }else if (num1 > num2 && num1 > num3)
        {
            Debug.Log("EL mayor es " + num1);
        }else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("EL mayor es " + num2);
        }
        else
        {
            Debug.Log("EL mayor es " + num3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
