using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remolino : MonoBehaviour
{
    public float speedRot = 400;

    public Transform remolinos;


    void Start()
    {

    }


    void Update()
    {


        remolinos.transform.Rotate(new Vector3(0f, 0f , - speedRot) * Time.deltaTime);

    }
}
