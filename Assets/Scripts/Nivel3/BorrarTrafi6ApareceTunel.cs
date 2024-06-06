using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTrafi6ApareceTunel : MonoBehaviour
{
    public GameObject Trafi6;
    public GameObject Tunel;
    public GameObject Trafi8;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi6.SetActive(false);
            Tunel.SetActive(true);
            Trafi8.SetActive(true);

        }
    }
}
