using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraTrafi5apareceTrafi7 : MonoBehaviour
{
    public GameObject Trafi7;
    public GameObject Trafi5;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            Trafi5.SetActive(false);
            Trafi7.SetActive(true);

        }
    }
}
