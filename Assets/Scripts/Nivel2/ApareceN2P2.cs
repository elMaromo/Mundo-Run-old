using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceN2P2 : MonoBehaviour
{
    public GameObject N2Parte2;
    public GameObject RioYPuente;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            N2Parte2.SetActive(true);
            Destroy(RioYPuente);

        }
    }
}
