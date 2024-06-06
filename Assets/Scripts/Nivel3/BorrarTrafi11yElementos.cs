using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarTrafi11yElementos : MonoBehaviour
{
    public GameObject Trafi11;
    
    public GameObject BorrarTunel;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            Destroy(Trafi11);
           
            Destroy(BorrarTunel);



        }
    }
}
