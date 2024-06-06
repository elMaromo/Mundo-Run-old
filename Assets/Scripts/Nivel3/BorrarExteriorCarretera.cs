using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarExteriorCarretera : MonoBehaviour
{
    public GameObject ExteriorCarretera3;
    public GameObject ExteriorCarretera4;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            ExteriorCarretera3.SetActive(false);
            ExteriorCarretera4.SetActive(false);

        }
    }
}
