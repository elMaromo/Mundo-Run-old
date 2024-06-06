using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTrafic10 : MonoBehaviour
{
    public GameObject trafi10;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            trafi10.SetActive(false);



        }
    }
}
