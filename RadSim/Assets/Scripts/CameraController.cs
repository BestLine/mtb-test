using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public float smothSpeed = 0.125f;
    public Vector3 offset; 

    void FixedUpdate()
    {
        offset.z = -10;
        offset.x = 5;
        Vector3 desiredPosition;

        if (target.position.y < -10)
        {
            desiredPosition = target.position + offset;
            desiredPosition.y = -10;
        }
        else {
            desiredPosition = target.position + offset;
        }

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smothSpeed); 


        transform.position = smoothedPosition;

    }




}
