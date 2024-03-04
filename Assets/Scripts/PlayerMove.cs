using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : Sounds
{
    private float speed = 5f;
    private float horizontal;
    private float jumpPower = 16f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

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
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
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
}