using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarDesguace : MonoBehaviour
{
    public GameObject Desguace;

    public GameObject Trafico;
    public GameObject ExteriorCarretera2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafico.SetActive(true);
            ExteriorCarretera2.SetActive(true);
            Destroy(Desguace);

        }
    }
}
