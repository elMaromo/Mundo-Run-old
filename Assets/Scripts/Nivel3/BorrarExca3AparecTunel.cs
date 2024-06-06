using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarExca3AparecTunel : MonoBehaviour
{
    //public GameObject ExteriorCarretera3;
    public GameObject Tunel;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            //ExteriorCarretera3.SetActive(false);
            Tunel.SetActive(true);


        }
    }
}
