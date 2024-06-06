using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceLagoSalida : MonoBehaviour
{
    public GameObject lagoSalida;





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            lagoSalida.SetActive(true);




        }

    }
}
