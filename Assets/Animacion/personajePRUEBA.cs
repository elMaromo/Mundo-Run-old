using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajePRUEBA : MonoBehaviour
{
    public GiroMundo PararMundo;
    // Start is called before the first frame update
    void Start()
    {
        PararMundo.speedRot = 10;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
