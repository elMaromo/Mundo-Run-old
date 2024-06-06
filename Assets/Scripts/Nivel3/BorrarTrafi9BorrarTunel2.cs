using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTrafi9BorrarTunel2 : MonoBehaviour
{
    public GameObject Trafi9;
    public GameObject BorrarTunel2;
    public GameObject Trafi11;
    public GameObject ActivadorCambiOnboard;
    public GameObject ExteriorCarretera5;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            ActivadorCambiOnboard.SetActive(true);
            Trafi9.SetActive(false);
            BorrarTunel2.SetActive(true);
            Trafi11.SetActive(true);
            ExteriorCarretera5.SetActive(true);


        }
    }
}
