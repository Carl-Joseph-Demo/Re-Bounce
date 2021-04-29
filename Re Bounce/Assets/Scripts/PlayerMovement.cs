using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public bool onTheGround = true;
    public float jumpVelocity;
    public float ballSpeed = 10.0f;

    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    //Check if the player is grounded
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            onTheGround = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            onTheGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            onTheGround = false;
        }
    }

    private void FixedUpdate()
    {
        
        

        //Player Movement Horizontal and Vertical
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);

        //Player can only move if on the ground
        if (onTheGround == true)
        {
            rb.AddForce(movement * ballSpeed);
        }

        //Jump
        if (Input.GetButton("Jump"))
        {
            if (onTheGround == true)
            {
                rb.AddForce(Vector3.up * jumpVelocity);
                //onTheGround = false;
            }
            else
            {

            }
        }
    }


}
