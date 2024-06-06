using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceCementerio : MonoBehaviour
{
    public GameObject cementerio;





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            cementerio.SetActive(true);





        }

    }
}
