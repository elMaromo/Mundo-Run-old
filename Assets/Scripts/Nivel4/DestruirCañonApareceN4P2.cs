using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCañonApareceN4P2 : MonoBehaviour
{
    public GameObject CañonSegundo;

    public MovimientoPMapita movimientopersonajeMapa;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(CañonSegundo);
            movimientopersonajeMapa.speedAcensor = 1.5f;


        }

    }
}
