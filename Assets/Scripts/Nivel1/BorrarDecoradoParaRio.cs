using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarDecoradoParaRio : MonoBehaviour
{
    public GameObject N1BorrarDecoradoRio;
    public GameObject RioYPuente;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            RioYPuente.SetActive(true);

            Destroy(N1BorrarDecoradoRio);
        }
    }
}
