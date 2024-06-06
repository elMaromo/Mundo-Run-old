using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraTraf7apartraf9 : MonoBehaviour
{
    public GameObject Trafi7;
    public GameObject Trafi9;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi7.SetActive(false);
            Trafi9.SetActive(true);

        }
    }
}
