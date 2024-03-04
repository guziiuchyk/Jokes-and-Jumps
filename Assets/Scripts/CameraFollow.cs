using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 3.0f;


    private void Awake()
    {
        transform.position = new Vector3()
        {
            x = playerTransform.position.x,
            y = playerTransform.position.y,
            z = playerTransform.position.z - 10
        };
    }
    private void Update()
    {
        Vector3 targer = new Vector3()
        {
            x = playerTransform.position.x,
            y = playerTransform.position.y,
            z = playerTransform.position.z - 10
        };
        Vector3 pos = Vector3.Lerp(transform.position, targer, speed * Time.deltaTime);
        transform.position = pos;
    }

}
