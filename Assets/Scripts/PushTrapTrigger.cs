using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTrapTrigger : Sounds
{
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] Transform trap;
    [SerializeField] float power = 10.0f;
    private bool IsItWorked = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!IsItWorked && collision.name == "Player")
        {
            PlaySound(sounds[0]);
            trap.position = new Vector2(trap.position.x, trap.position.y + 1);
            playerRb.velocity = new Vector2(playerRb.velocity.x, power);
            IsItWorked = true;
        }
    }
}
