using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarN1ApareceN2 : MonoBehaviour
{
    public GameObject Nivel1;
    public GameObject Nivel2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            Nivel2.SetActive(true);
            Destroy(Nivel1);
        }
    }
}
