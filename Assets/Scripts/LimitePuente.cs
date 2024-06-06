using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitePuente : MonoBehaviour
{
    public MovimientoPMapita movimientopersonajeMapa;




    public Jugador jugador;
    public void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            movimientopersonajeMapa.speedAcensor = 18;
            jugador.LimitedePistaPositivo = 0.29f;
            jugador.LimitedePistanegativo = -1.3f;

        }
  
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {

            movimientopersonajeMapa.speedAcensor = 1.2f;
            jugador.LimitedePistaPositivo = 3;
            jugador.LimitedePistanegativo = -3;

        }
    }
}
