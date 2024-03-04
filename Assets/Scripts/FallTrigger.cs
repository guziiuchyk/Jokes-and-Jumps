using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("FALL");
        if (collision.name == "Player")
        {
            

        } else
        {
            Debug.Log("NOT PLAYER DESTROY");
            Destroy(collision.gameObject);
        }
    }
}
