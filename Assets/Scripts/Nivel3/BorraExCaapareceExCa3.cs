using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraExCaapareceExCa3 : MonoBehaviour
{
    public GameObject ExteriorCarretera;
    public GameObject ExteriorCarretera3;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            
            ExteriorCarretera.SetActive(false);
            ExteriorCarretera3.SetActive(true);


        }
    }
}
