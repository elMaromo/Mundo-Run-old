using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraN4ApareN5 : MonoBehaviour
{
    public GameObject nivel5;
    public GameObject nivel4;
    public GameObject cementerio2;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            nivel5.SetActive(true);
            cementerio2.SetActive(true);
            Destroy(nivel4);





        }

    }
}
