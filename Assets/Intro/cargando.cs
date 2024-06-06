using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cargando : MonoBehaviour
{
    public Slider slider;
    public float velocidad = 0.1f;
   

    void Start()
    {
        // Puedes establecer un valor inicial para el slider aquí, si es necesario
        // slider.value = 0.0f;
    }

    void Update()
    {
        // Asegúrate de que el slider no supere el valor máximo
        if (slider.value < slider.maxValue)
        {
            // Incrementa el valor del slider con el tiempo
            slider.value += Time.deltaTime * velocidad;

        }
    }
}
