using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraCementeioParte1 : MonoBehaviour
{
   
    public GameObject cementerio1;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            Destroy(cementerio1);





        }

    }
}
