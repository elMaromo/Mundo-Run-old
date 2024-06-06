using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{

    

    void Start()
    {
        
    }


    void Update()
    {

    }
    public void OnCollisionStay(Collision collision)
    {

        if (collision.collider.CompareTag("Pies"))
        {
            gameObject.tag = "Tierra";

        }

    }
    public void OnCollisionExit(Collision collision)
    {

        if (collision.collider.CompareTag("Pies"))
        {
            gameObject.tag = "Untagged";

        }


    }
}
