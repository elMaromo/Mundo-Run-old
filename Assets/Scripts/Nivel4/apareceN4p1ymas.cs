using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apareceN4p1ymas : MonoBehaviour
{
    public GameObject n4P1;
    public GameObject casasnueva1;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            casasnueva1.SetActive(true);
            Destroy(n4P1);
            



        }

    }
}
