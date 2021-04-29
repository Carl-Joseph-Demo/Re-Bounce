using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalLogic : MonoBehaviour
{
    public Transform objectToTeleport;
    public Transform teleportTo;

    void Start()
    {
        objectToTeleport = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //player layer
        if (collision.gameObject.tag == "Player" && teleportTo != null)
        {
            objectToTeleport.position = teleportTo.position;
        }
    }
}
