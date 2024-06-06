using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Borra2ApareceParte3 : MonoBehaviour
{
    public GameObject N1Parte2;
    public GameObject N1Parte3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Destroy(N1Parte2);
            N1Parte3.SetActive(true);
        }
    }
}
