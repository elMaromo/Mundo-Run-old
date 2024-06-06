using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empiezaJuego : MonoBehaviour
{

    public GiroMundo PararMundo;

    public GameObject personaje;
    public GameObject SonidoCampo;

    void Start()
    {
        PararMundo.speedRot = 10;
        SonidoCampo.SetActive(true);

    }

}
