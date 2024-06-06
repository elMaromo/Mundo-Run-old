using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GiroActivaCano : MonoBehaviour
{
    public GiroMundo PararMundo;

    public Transform activacano;

    public bool funcionaActivaCano = false;
    void Update()
    {

        if (funcionaActivaCano == true)
        {
            float speed = PararMundo.speedRot;
            activacano.transform.Rotate(new Vector3(-speed, 0f, 0f) * Time.deltaTime);

        }

    }
    
}
