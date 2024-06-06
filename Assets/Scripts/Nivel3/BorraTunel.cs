using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraTunel : MonoBehaviour
{
    public GameObject Tuneles;
   




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            Destroy(Tuneles);



        }
    }
}
