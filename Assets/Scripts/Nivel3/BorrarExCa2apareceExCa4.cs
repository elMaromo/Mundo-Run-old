using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarExCa2apareceExCa4 : MonoBehaviour
{
    public GameObject ExteriorCarretera2;
    public GameObject ExteriorCarretera4;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            ExteriorCarretera2.SetActive(false);
            ExteriorCarretera4.SetActive(true);


        }
    }
}
