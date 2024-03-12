using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] public bool IsIdle = true;
    [SerializeField] public bool IsFollow = false;
    [SerializeField] float speed = 1f;
    [SerializeField] Transform playerTransform;
    private float t = 0f;
    private float OffSet = 0f;
    private float Freq = 2f;
    private float Amp = 0.3f;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if(IsFollow)
        {
            Vector3 target = new Vector3()
            {
                x = playerTransform.position.x + 0.8f,
                y = playerTransform.position.y,
                z = playerTransform.position.z
            };
            Vector3 pos = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
            transform.position = pos;
        }
        if(IsIdle) 
        { 
            t = t + Time.deltaTime;
            OffSet = Amp * Mathf.Sin(t * Freq);
            transform.position = startPos + new Vector3(0,OffSet,0);
        }
    }
}
