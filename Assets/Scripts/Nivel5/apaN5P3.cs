using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apaN5P3 : MonoBehaviour
{
    public GameObject n5P3;
    public GameObject n5P1;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            n5P3.SetActive(true);
            Destroy(n5P1);







        }

    }
}
