using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunel2Parte : MonoBehaviour
{
    public GameObject ApareceTunel2;
    public GameObject SistemaBorrarTunel2;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {




            ApareceTunel2.SetActive(true);
            Destroy(SistemaBorrarTunel2);

        }
    }
}
