using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ApareN6BorraN5 : MonoBehaviour
{
    
    public GameObject nivel6;
    public GameObject nivel5;


    public MovimientoPMapita movimientopersonajeMapa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            movimientopersonajeMapa.speedAcensor = 3f;

            nivel6.SetActive(true);
           


            Destroy(nivel5);
            

        }

    }
}
