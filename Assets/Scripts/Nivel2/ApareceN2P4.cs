using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceN2P4 : MonoBehaviour
{
    public GameObject N2Parte2;
    public GameObject N2Parte4;
   


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            N2Parte4.SetActive(true);
            
            Destroy(N2Parte2);

        }
    }
}
