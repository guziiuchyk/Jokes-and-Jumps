using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : Sounds
{
    [SerializeField] Key key;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            collision.gameObject.GetComponent<PlayerMove>().IsHaveKey = true;
            PlaySound(sounds[0], volume:0.7f);
            key.IsFollow = true;
            key.IsIdle = false;
        }
    }
}
