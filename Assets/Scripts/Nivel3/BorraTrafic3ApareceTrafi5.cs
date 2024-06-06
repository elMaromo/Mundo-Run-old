using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraTrafic3ApareceTrafi5 : MonoBehaviour
{
    public GameObject Trafi3;
    public GameObject Trafi5;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi3.SetActive(false);
            Trafi5.SetActive(true);

        }
    }
}
