using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceArbolDondeRio : MonoBehaviour
{
    public GameObject ArbolesDondeRio;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            ArbolesDondeRio.SetActive(true);
            
        }
    }
}
