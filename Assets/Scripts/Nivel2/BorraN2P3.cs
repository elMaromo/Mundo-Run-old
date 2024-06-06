using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraN2P3 : MonoBehaviour
{
    public GameObject N2Parte3;
    public GameObject Desguace;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Desguace.SetActive(true);

            Destroy(N2Parte3);
        }
    }
}
