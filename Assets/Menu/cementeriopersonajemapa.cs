using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cementeriopersonajemapa : MonoBehaviour
{
    public MovimientoPMapita movimientopersonajeMapa;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            movimientopersonajeMapa.speedAcensor = 3.6f;


        }

    }
}
