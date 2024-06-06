using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apaN4P3BorraDecoradoCiu2 : MonoBehaviour
{
    public GameObject n4P2;
    public GameObject n4P2b;
    public GameObject n4P3;
    public GameObject n4P4;
    public GameObject decoradoCiudad2;
    public GameObject decoradoCiudad3;
    public GameObject apareceN4P2;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            n4P3.SetActive(true);
            n4P4.SetActive(true);
            decoradoCiudad3.SetActive(true);
            Destroy(n4P2);
            Destroy(n4P2b);
            Destroy(decoradoCiudad2);
            Destroy(apareceN4P2);



        }

    }
}
