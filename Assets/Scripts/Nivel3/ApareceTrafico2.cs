using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceTrafico2 : MonoBehaviour
{
    public GameObject Trafi2;
    public GameObject Loqueborradesguace;
   



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            Trafi2.SetActive(true);
            Destroy(Loqueborradesguace);
            


        }
    }
}
