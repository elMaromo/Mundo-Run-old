using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTraf8Aparecetraf10 : MonoBehaviour
{
    public GameObject Trafi8;
    public GameObject Trafi10;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi8.SetActive(false);
            Trafi10.SetActive(true);

        }
    }
}
