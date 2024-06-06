using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrTraf4ApareTrafi6 : MonoBehaviour
{
    public GameObject Trafi6;
    public GameObject Trafi4;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi6.SetActive(true);
            Trafi4.SetActive(false);

        }
    }
}
