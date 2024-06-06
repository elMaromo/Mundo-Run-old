using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraTrafi2ApareTrafi4 : MonoBehaviour
{
    public GameObject Trafi2;
    public GameObject Trafi4;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi4.SetActive(true);
            Trafi2.SetActive(false);

        }
    }
}
