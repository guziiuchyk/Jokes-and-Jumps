using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenLayer222 : MonoBehaviour
{
    [SerializeField] GameObject HiddelLayer;
    [SerializeField] GameObject Block;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            HiddelLayer.SetActive(false);
            Block.SetActive(true);
        }
    }
}
