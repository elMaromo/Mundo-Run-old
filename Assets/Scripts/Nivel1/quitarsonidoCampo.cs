using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarsonidoCampo : MonoBehaviour
{
    public GameObject sonidocampo;
 

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            sonidocampo.SetActive(false);

        }

    }





}
