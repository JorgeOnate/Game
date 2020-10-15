using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator _animator;

    public bool facingRight;
    public float horizontalValue;
    
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public float jumpImpulse = 10f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update () {
        Jump();
        Run();
        Flip();
    }

    void Run()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        horizontalValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if (Input.GetAxis("Horizontal") != 0)
        {
            _animator.SetBool("isRunning",true);
        }
        else
        {
            _animator.SetBool("isRunning",false);
        }
        
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded.Equals(true))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jumpImpulse),ForceMode2D.Impulse);
        }

        if (Input.GetAxis("Jump") != 0)
        {
            _animator.SetTrigger("jump");
        }

    }

    void Flip()
    {
        if ((horizontalValue > 0 && facingRight) || (horizontalValue < 0 && !facingRight))
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}