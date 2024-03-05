using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformPlayerTrigger : MonoBehaviour
{
    [SerializeField] MovePlatform _movePlatform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            _movePlatform.isPlayerInside = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            _movePlatform.isPlayerInside = false;
        }
    }
}
