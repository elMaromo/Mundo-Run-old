using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraCañon1ApareceN4 : MonoBehaviour
{
    public GameObject CañonPrimero;
    public GameObject Nivel4;
    public GameObject Nivel3;
    public GameObject ActivadorCañon;
    public GameObject ActivadorCañon2;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Nivel4.SetActive(true);
            Destroy(CañonPrimero);
            Destroy(Nivel3);
            Destroy(ActivadorCañon);
            Destroy(ActivadorCañon2);


        }

    }
}
