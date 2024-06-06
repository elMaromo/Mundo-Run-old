using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarLagoApareceM5P2 : MonoBehaviour
{
    public GameObject quitarLago;
    public GameObject n5P2;





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            Destroy(quitarLago);
            n5P2.SetActive(true);




        }

    }
}
