using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceN4P2 : MonoBehaviour
{
    public GameObject aceraHorizontal;
    public GameObject n4P2;
    public GameObject n4P2b;
    public GameObject decoradoCiudad2;
    public GameObject boran4p1ApaN4p3BorraDecoradoCiu2;
    public GameObject apareceN4P1;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            n4P2.SetActive(true);
            n4P2b.SetActive(true);
            decoradoCiudad2.SetActive(true);
            Destroy(aceraHorizontal);
            boran4p1ApaN4p3BorraDecoradoCiu2.SetActive(true);
            apareceN4P1.SetActive(true);

        }

    }
}
