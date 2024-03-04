using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeTrigger : MonoBehaviour
{
    [SerializeField] new GameObject gameObject;
    private FallingSpike fallingSpike;


    private void Start()
    {
        fallingSpike = gameObject.GetComponent<FallingSpike>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player" && gameObject != null)
        {
            Debug.Log(fallingSpike);
            fallingSpike.isMoving = true;
        }
    }
}
