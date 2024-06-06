using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apaN5p1ExteriorLago : MonoBehaviour
{
    public GameObject n5P1;
    public GameObject exteriorLago;
    public Camaras camara;

    public GameObject sonidoMar;





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            n5P1.SetActive(true);
            exteriorLago.SetActive(true);
            camara.Camaraprincipal = false;
            sonidoMar.SetActive(true);






        }

    }
}
