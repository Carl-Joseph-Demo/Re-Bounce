using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector3 cameraOffset;

    public float camPitch;
    public float camYaw;
    
    void Update()
    {
        //Follow the Player
        transform.position = objectToFollow.position + cameraOffset;

        //Reorient the Camera
        //camYaw += Input.GetAxis("Mouse X");
        //camPitch -= Input.GetAxis("Mouse Y");

        //transform.eulerAngles = new Vector3(camPitch, camYaw, 0.0f);
    }
}
