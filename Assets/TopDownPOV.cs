using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPOV : MonoBehaviour
{

    private Transform Target;
    public float distance = 5;
    private float angle = 43;
    private float height = 9.5f;
    private float smoothness = 0.6f;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    private void TdCam()
        if (!Target)
           return;

        Vector3 vector3 = (Vector3.forward * -distance) + (Vector3.up * height);

}

   




    
