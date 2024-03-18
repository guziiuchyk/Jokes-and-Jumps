using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : Sounds
{
    private float speed = 5f;
    private float horizontal;
    private Animator animator;
    private bool FacingRight = true;
    [SerializeField] float jumpPower = 16f;
    [SerializeField] public bool IsHaveKey = false;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    

    // Update is called once per frame
    private void Start()
    {
        animator = GetComponent<Animator>();
        if (Settings.IsDarkSoulsOn)
        {
            PlaySound(sounds[3], volume:0.4f);
        }
        else
        {
            PlaySound(sounds[2], volume:0.7f);
        }
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("HorizontalMove", Math.Abs(horizontal) * speed);
        if (IsGrounded()) 
        {
            animator.SetBool("Jumping", false);
        } else
        {
            animator.SetBool("Jumping", true);
        }
        if (horizontal < 0 && FacingRight)
        {
            Flip();
        }
        else if (horizontal > 0 && !FacingRight)
        {
            Flip();
        }
        if (rb.gravityScale < 0 && jumpPower > 0)
        {
            jumpPower = jumpPower * -1;
        }
        if (Input.GetButtonDown("Jump") && IsGrounded())
        { 
            if (Settings.IsDarkSoulsOn)
            {
                PlaySound(sounds[1], volume: 0.8f);
            }
            else
            {
                PlaySound(sounds[0], volume: 0.5f);
            }
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        if (Input.GetButtonUp("Jump") || Input.GetKeyUp(KeyCode.Joystick1Button0) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        Debug.Log(isGrounded);
        return isGrounded;
    }
    private void Flip()
    {
        FacingRight = !FacingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
