using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTunel : MonoBehaviour
{

    public GameObject ActivarElTunel;
    public GameObject BorradorElBorrarDesguace;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Destroy(BorradorElBorrarDesguace);
            ActivarElTunel.SetActive(true);

        }
    }
}
