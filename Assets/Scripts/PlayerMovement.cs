using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public float jumpImpulse = 10f;
    void Start ()
    {
        
    }
    void Update () {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded.Equals(true))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jumpImpulse),ForceMode2D.Impulse);
        }
        
    }
}