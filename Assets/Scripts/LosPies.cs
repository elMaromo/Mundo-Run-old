using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosPies : MonoBehaviour
{

    
    public Jugador jugador;

    public float height;
    RaycastHit hit;

    public bool SigueCorriendo = true;



    void Start()
    {
        
        jugador = FindObjectOfType<Jugador>();
    }


    void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);

        Debug.DrawRay(transform.position, Vector3.down * height, Color.red);
        
        if(Physics.Raycast(ray, out hit))
        {
           
            if (hit.collider.tag == "Tierra")
            {

                SigueCorriendo = false;


            }
            if (hit.collider.tag == "Untagged")
            {
                SigueCorriendo = true;
                jugador.PuedeAgachar = true;
                hit.collider.tag = "Tierra";

            }

        }
    }
    
}
