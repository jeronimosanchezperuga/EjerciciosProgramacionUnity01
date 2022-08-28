using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios10 : MonoBehaviour
{
    public int horasTrabajadas;
    public int valorHoraHasta40 = 16;
    public int valorHoraDesde41 = 20;

    // Start is called before the first frame update
    void Start()
    {
        int sueldoSemanal;
        if (horasTrabajadas <= 40)
        {
            sueldoSemanal = horasTrabajadas * valorHoraHasta40;
        }
        else
        {
            int sueldoHasta40 = 40 * valorHoraHasta40;
            int horasSuperandoLas40 = horasTrabajadas - 40;
            sueldoSemanal = sueldoHasta40 + horasSuperandoLas40 * valorHoraDesde41;
        }

        Debug.Log("EL sueldo semanal es de $" + sueldoSemanal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
