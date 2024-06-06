using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borra1ApareceParte4 : MonoBehaviour
{
    public GameObject N1Parte1;
    public GameObject N1Parte4;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            N1Parte4.SetActive(true);
            Destroy(N1Parte1);
            
        }
    }
}
