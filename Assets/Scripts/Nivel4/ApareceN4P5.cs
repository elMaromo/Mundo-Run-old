using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceN4P5 : MonoBehaviour
{
    public GameObject n4P5;
    




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            n4P5.SetActive(true);
            




        }

    }
}
