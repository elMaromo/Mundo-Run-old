using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraTrafi1Apatrafi3 : MonoBehaviour
{
    public GameObject Trafi1;
    public GameObject Trafi3;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi3.SetActive(true);
            Trafi1.SetActive(false);

        }
    }
}
