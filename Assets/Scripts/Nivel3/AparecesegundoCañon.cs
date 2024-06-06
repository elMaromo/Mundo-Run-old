using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecesegundoCañon : MonoBehaviour
{
    public GameObject CañonSegundo;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CañonSegundo.SetActive(true);


        }

    }
}
