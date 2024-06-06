using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraDecoradoObjetos : MonoBehaviour
{
    
    public GameObject n4P3;
    public GameObject n4P4;
    public GameObject boran4p1ApaN4p3BorraDecoradoCiu2;
    public GameObject decoradoCiudad3;
   




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            
            
            Destroy(n4P4);
            Destroy(decoradoCiudad3);
            Destroy(n4P3);
            Destroy(boran4p1ApaN4p3BorraDecoradoCiu2);


        }

    }
}
