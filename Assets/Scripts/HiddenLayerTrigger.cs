using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenLayerTrigger : MonoBehaviour
{
    [SerializeField] GameObject HiddenLayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name != "Player")
        {
            Destroy(collision.gameObject);
            HiddenLayer.SetActive(false);
        }
    }
}
