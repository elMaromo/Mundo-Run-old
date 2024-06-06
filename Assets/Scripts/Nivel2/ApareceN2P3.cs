using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceN2P3 : MonoBehaviour
{
    public GameObject N2Parte3;
    public GameObject N2Parte1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            N2Parte3.SetActive(true);
            Destroy(N2Parte1);

        }
    }
}
