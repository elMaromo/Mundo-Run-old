using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarN2ApareceN3 : MonoBehaviour
{
    public GameObject N2;
    public GameObject N3;
    public GameObject ExteriorCarretera;

    public MovimientoPMapita movimientopersonajeMapa;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            movimientopersonajeMapa.speedAcensor = 6.8f;
            N3.SetActive(true);
            ExteriorCarretera.SetActive(true);
            Destroy(N2);

        }
    }
}
