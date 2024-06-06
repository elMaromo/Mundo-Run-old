using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTuenl2 : MonoBehaviour
{
    
    public GameObject BorrarTunel2;
    public GameObject ApareceBorrarTunel1;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ApareceBorrarTunel1.SetActive(true);
            Destroy(BorrarTunel2);

            

        }
    }
}
