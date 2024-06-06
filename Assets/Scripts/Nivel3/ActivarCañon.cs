using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCañon : MonoBehaviour
{
    public GameObject Cañon;

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cañon.SetActive(true);
           

        }

    }
}
